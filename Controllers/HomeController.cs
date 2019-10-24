using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultasTransito.Models;
using MultasTransito.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Fabric.Query;

namespace MultasTransito.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ApplicationDbContext db = new ApplicationDbContext();        

        //Inyección de dependencia
        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;            
        }
         
        public IActionResult Index() 
        {            
            string[] NombreMunis = { "Guatemala", "Mixco", "Villa Nueva", "San José Pinula", "Fraijanes" };
            ViewBag.NombreMunis = NombreMunis;
            ViewBag.NombreMunisLenght = NombreMunis.Length;
            /*IList<Vehiculo> vehiculosList = new List<Vehiculo>
            {
                new Vehiculo() { IdNit = 784512 },
                new Vehiculo() { TipoPlaca = "P" },
                new Vehiculo() { IdPlaca = 123456789 }
            };
            ViewData["DatosVehiculo"] = vehiculosList;*/ 

            return View();
        }
      
        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";
            return View();
        }

        public ViewResult ShowView()
        {
            ViewBag.Logo = Url.Action("");
            return View();
        }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";

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
