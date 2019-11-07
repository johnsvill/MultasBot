using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultasTransito.Data;
using MultasTransito.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;    
using Grpc.Core;
using System.Data;
using Microsoft.AspNetCore.Http;
using ExcelDataReader;

namespace MultasTransito.Controllers
{    
    public class HomeController : Controller
    {
        /*SqlConnection connect = new SqlConnection(System.Configuration.ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString);*/
        private readonly ApplicationDbContext dbContext;         

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
                return View();
            }
            else
            {
                return PartialView("_LoginPartial");
            }                        
        }

        //Obtiene el contenido del documento de excel  
        //Guardando el documento
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IFormFile file)
        {
            if (file != null)
            {
                if (!file.FileName.EndsWith(".xls") && !file.FileName.EndsWith(".xlsx"))
                    return View();

                var fileName = DateTime.Now.ToString("dd-MM-yyyy") + file.FileName.Split(new[] { '.' },
                    StringSplitOptions.RemoveEmptyEntries).Last();
                SaveFile(file, fileName);
                UploadToDataBase(fileName);
                return RedirectToAction("Index");
            }
            
            return View("Carga correcta");

            /*string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            string filePath = "/DataExcel/Data.xlsx" + fileName;    
            file.SaveAs(Path.Combine(Server.MapPath("/DataExcel/Data.xlsx"), fileName));            

            if(file == null) // || file.ContentLenght == 0
            {
                ViewBag.Error = "Por favor seleccione un archivo de excel";
                return View("Index");
            }
            else
            {                
                if (file.FileName.EndsWith("xls") || file.FileName.EndsWith("xlsx"))
                {
                    string path = Server.MapPath("/DataExcel/Data.xlsx" + file.FileName);
                    if (System.IO.File.Exists(path))
                        System.IO.File.Delete(path);
                    file.SaveAs(path);
                    Excel.Application application = new Excel.Application();
                    Excel.Workbook workbook = application.Workbooks.Open(path);
                    Excel.Worksheet worksheet = NewMethod(workbook);
                    Excel.Range range = worksheet.UsedRange;
                    List<Vehiculo> listVehiculo = new List<Vehiculo>();
                    for (int row = 10; row < range.Rows.Count; row++)
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
            }  */
        }

        private void SaveFile(IFormFile file, string fileName)
        {
            throw new NotImplementedException();
        }

        private void SaveFile(HttpPostedFileBase file, string fileName)
        {
            var path = System.IO.Path.Combine(Server.MapPath("~/DataExcel/Data.xlsx"), fileName);
            var data = new byte[file.ContentLength];
            file.InputStream.Read(data, 0, file.ContentLength);

            using (var sw = new System.IO.FileStream(path, System.IO.FileMode.Create))
            {
                sw.Write(data, 0, data.Length);
            }
        }

        //Extraer los datos del documento y subirlos a la BD
        private void UploadToDataBase(string fileName)
        {
            var vehiculo = new List<Vehiculo>();
            using (var stream = System.IO.File.Open(Path.Combine(Server.MapPath("~/DataExcel/Data.xlsx"),
                fileName), FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        vehiculo.Add(new Vehiculo
                        {
                            IdNit = reader.RowCount,
                            Color = Convert.ToString(reader.RowCount),
                            Marca = Convert.ToString(reader.RowCount),
                            Modelo = Convert.ToString(reader.RowCount),
                            Año = reader.RowCount,
                            IdMulta = reader.RowCount,
                            IdPlaca = reader.RowCount,
                            TipoPlaca = Convert.ToString(reader.RowCount),
                            NumeroPlaca = Convert.ToString(reader.RowCount)
                        });
                    }
                }
            }
            if (vehiculo.Any())
            {
                dbContext.Vehiculo.AddRange(vehiculo);
                dbContext.SaveChanges();
            }
        }
     
        //Enlaza la conexión con el origen de datos
        /*private void ExcelConnect(string filePath)
        {
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
                    Data Source=/DataExcel/Data.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES; IMEX = 0;", filePath);                       
        }*/

        //Setea un objeto con las columnas del documento, realiza la carga masiva, abre y cierra la conexión a la BD
        /*private void InsertExcelData(string filePath, string fileName)
        {            
            string query = string.Format("Select * from [{0}]", "Hoja1");
            
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
        }*/

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
