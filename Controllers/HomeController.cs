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
using Microsoft.AspNetCore.Http;

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
         
        [HttpPost]
        public IActionResult Index() //string nit, string tipoPlaca, string numeroPlaca
        {
            /*Vehiculo vh = new Vehiculo
            {
                IdNit = Convert.ToInt32(nit),
                TipoPlaca = tipoPlaca,
                IdPlaca = Convert.ToInt32(numeroPlaca)
            };*/
            string[] NombreMunis = { "Guatemala", "Mixco", "Villa Nueva", "San José Pinula", "Fraijanes" };
            ViewBag.NombreMunis = NombreMunis;
            ViewBag.NombreMunisLenght = NombreMunis.Length;                     
            return View();
        }

       /* public ActionResult Form(FormCollection formCollection)
        {
            string _Nit = formCollection["Nit"];
            string _TipoPlaca = formCollection["Tipo de placa"];
            string _NumeroPlaca = formCollection["Numero de placa"];

            return View("Form");
        }*/

        /*IList<Vehiculo> vehiculosList = new List<Vehiculo>
            {
                new Vehiculo() { IdNit = 0 },
                new Vehiculo() { TipoPlaca = "" },
                new Vehiculo() { IdPlaca = 0 }
            };
            ViewData["DatosVehiculo"] = vehiculosList;   */

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
