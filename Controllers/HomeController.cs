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
using Microsoft.Office.Interop.Excel;
using System.IO;
using Grpc.Core;
using ExcelDataReader;
using System.Data;

namespace MultasTransito.Controllers
{    
    public class HomeController : Controller
    {
        SqlConnection connect = new SqlConnection(System.Configuration.ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString);              
        private readonly ApplicationDbContext dbContext;
        OleDbConnection Econ; 
       
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

        /*public ActionResult Index(HttpPostedFileBase file)
        {
            string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            string filepath = "/DataExcel/Data.xlsx" + fileName;

            file.SaveAs(Path.Combine(Server.MapPath("/DataExcel/Data.xlsx"), fileName));
            InsertExcelData(filepath, fileName);

            return View();
        }*/

        private void ExcelConnect(string filePath)
        {
            string constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", filePath);

            Econ = new OleDbConnection(constr);
        }
        
        private void InsertExcelData(string filePath, string fileName)
        {
            string fullpath = Server.MapPath("/DataExcel/Data.xlsx") + fileName;
            ExcelConnect(fullpath);
            string query = string.Format("Select * from [{0}]", "Hoja1");
            OleDbCommand Ecom = new OleDbCommand(query, Econ);
            Econ.Open();            
            oda = new OleDbDataAdapter(query, Econ);
            Econ.Close();
            oda.Fill(ds);

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

                /*var searchMultas = from e in dbContext.Multas 
                                   join d in multas on e.Idnit equals d.IdMulta                           
                                   join i in vehiculos on  equals i.TipoPlaca   
                                   join p in propietarios on i.IdNit  equals i.NumeroPlaca

                                   select new 
                                   {                                       
                                       multas = e,
                                       vehiculo = d,                                       
                                   };*/
            }           
      }

        /*var searchMultas = dbContext.Multas;
           int searchInt = Convert.ToInt32(searchString);

           if (!String.IsNullOrEmpty(searchString))
           {
               this.dbContext.Multas.Where(x => x.Idnit == searchInt);
               searchString = dbContext.Find();
           }

           return PartialView(await searchMultas.ToListAsync());*/

        /*IList<Vehiculo> vehiculosList = new List<Vehiculo>
           {
               new Vehiculo() { IdNit = 784512 },
               new Vehiculo() { TipoPlaca = "P" },
               new Vehiculo() { IdPlaca = 123456789 }
           };
           ViewData["DatosVehiculo"] = vehiculosList;*/

        public IActionResult About()
        {
            //ViewData["Message"] = "";
            return View();
        }

        public ViewResult ShowView()
        {
            ViewBag.Logo = Url.Action("");
            return View();
        }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "";
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
