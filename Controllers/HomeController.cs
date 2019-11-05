using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultasTransito.Data;
using MultasTransito.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;    
using Grpc.Core;
using ExcelDataReader;  
using System.Data;
using Microsoft.AspNetCore.Http;

namespace MultasTransito.Controllers
{    
    public class HomeController : Controller
    {                     
        private readonly ApplicationDbContext dbContext;
        //OleDbConnection Econ;       

        //Inyección de dependencia
        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;             
        }
        
        public IActionResult Index([FromServices] SignInManager<IdentityUser> signInManager) 
        {           
            string[] NombreMunis = { "Guatemala", "Mixco", "Villa Nueva", "San José Pinula", "Fraijanes" };
            ViewBag.NombreMunis = NombreMunis;
            ViewBag.NombreMunisLenght = NombreMunis.Length;

            RedirectToAction("B", "Search", new { searchString = "Filtrando datos" });            

            if (signInManager.IsSignedIn(User))
            {
                return View(new List<Vehiculo>());
            }
            else
            {
                return PartialView("_LoginPartial");
            }                        
        }
      
        //Obtiene el contenido del documento de excel
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            string fileName = Guid.NewGuid() + Path.GetExtension(file.fileName);
            /*string filePath = "/DataExcel/Data.xlsx" + fileName;    
            file.SaveAs(Path.Combine(Server.MapPath("/DataExcel/Data.xlsx"), fileName));
            InsertExcelData(filePath, fileName);*/   

            if(file == null || file.ContentLenght == 0)
            {
                ViewBag.Error = "Por favor seleccione un archivo de excel";
                return View("Index");
            }
            else
            {                
                if (file.FileName.EndsWith("xls") || file.FileName.EndsWith("xlsx"))
                {
                    string path = Server.MapPath("/DataExcel/Data.xlsx" + file.fileName);
                    if (System.IO.File.Exists(path))
                        System.IO.File.Delete(path);
                    file.SaveAs(path);
                    Excel.Application application = new Excel.Application();
                    Excel.Workbook workbook = application.Workbooks.Open(path);                    
                    Excel.Worksheet worksheet = workbook.ActiveSheet;
                    Excel.Range range = worksheet.UsedRange;
                    List<Vehiculo> listVehiculo = new List<Vehiculo>();
                    for(int row = 10; row < range.Rows.Count; row++)
                    {
                        Vehiculo vh = new Vehiculo
                        {
                            IdPlaca = Convert.ToInt32(((Excel.Range)range.Cells[row, 1]).Text),
                            Color = Convert.ToString(((Excel.Range)range.Cells[row, 2]).Text),
                            IdNit = Convert.ToInt32(((Excel.Range)range.Cells[row, 3]).Text),
                            Marca = Convert.ToString(((Excel.Range)range.Cells[row, 4]).Text),
                            Modelo = Convert.ToString(((Excel.Range)range.Cells[row, 5]).Text),
                            Año = Convert.ToInt32(((Excel.Range)range.Cells[row, 6]).Text),
                            IdMulta = Convert.ToInt32(((Excel.Range)range.Cells[row, 7]).Text),
                            TipoPlaca = Convert.ToString(((Excel.Range)range.Cells[row, 8]).Text),
                            NumeroPlaca = Convert.ToString(((Excel.Range)range.Cells[row, 9]).Text)
                        };
                    }
                    ViewBag.ListVehiculo = listVehiculo;
                    return View("Carga correcta");
                }
                else
                {
                    ViewBag.Error = "Tipo de archivo es inválido";
                    return View("Index");
                }
            }                   
        }
        
        //Enlaza la conexión con el origen de datos
        private void ExcelConnect(string filePath)
        {
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=/DataExcel/Data.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES; IMEX = 0;", filePath);            

            //Econ = new OleDbConnection(constr);
        }

        //Setea un objeto con las columnas del documento, realiza la carga masiva, abre y cierra la conexión a la BD
        private void InsertExcelData(string filePath, string fileName)
        {
            SqlConnection connect = new SqlConnection(System.Configuration.ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString);
            string query = string.Format("Select * from [{0}]", "Hoja1");
            /*string fullpath = Server.MapPath("/DataExcel/Data.xlsx") + fileName;
            ExcelConnect(fullpath);            
            OleDbCommand Ecom = new OleDbCommand(query, Econ);
            Econ.Open();            
            oda = new OleDbDataAdapter(query, Econ);
            Econ.Close();
            oda.Fill(ds);*/

            DataSet ds = new DataSet();
            System.Data.DataTable dt = ds.Tables[0];
            
            SqlBulkCopy objBulk = new SqlBulkCopy(connect)
            {
                DestinationTableName = "Vehiculo"
            };
            objBulk.ColumnMappings.Add("IdPlaca", "IdPlaca");
            objBulk.ColumnMappings.Add("Color", "Color");
            objBulk.ColumnMappings.Add("IdNit", "IdNit");
            objBulk.ColumnMappings.Add("Marca", "Marca");
            objBulk.ColumnMappings.Add("Modelo", "Modelo");
            objBulk.ColumnMappings.Add("Año", "Año");
            objBulk.ColumnMappings.Add("IdMulta", "IdMulta");
            objBulk.ColumnMappings.Add("TipoPlaca", "TipoPlaca");
            objBulk.ColumnMappings.Add("NumeroPlaca", "NumeroPlaca");

            connect.Open();
            objBulk.WriteToServer(dt);
            connect.Close();
        }

      // Inner Join 3 tablas
      [HttpPost]
      public IActionResult Search(string searchString)
      {           
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                List<Propietario> propietarios = dbContext.Propietarios.ToList();
                List<Multas> multas = dbContext.Multas.ToList();
                List<Vehiculo> vehiculos = dbContext.Vehiculo.ToList();

                var searchMultas = from m in dbContext.Multas   
                                  join v in dbContext.Vehiculo on m.IdMulta equals v.IdNit
                                  let p = dbContext.Propietarios.Where(x => x.IdNit == v.IdNit 
                                  && x.IdNit >= v.IdPlaca && x.IdNit == Convert.ToInt32(v.NumeroPlaca))
                                  where v.NumeroPlaca == null
                                            
                  orderby m.Monto, v.TipoPlaca, v.NumeroPlaca, v.IdNit 
                  select new 
                  {
                      multas = m,
                      propietarios = p,
                      vehiculos = v
                  };
                return PartialView(searchMultas);              
            }           
      }
              
        public IActionResult About()
        {            
            return View();
        }
      
        public IActionResult Contact()
        {            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }    
}
