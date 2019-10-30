using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultasTransito.Data;
using MultasTransito.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MultasTransito.Controllers
{    
    public class HomeController : Controller
    {
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
           
            if(signInManager.IsSignedIn(User))
            {
                return View();
            }
            else
            {
                return PartialView("_LoginPartial");
            }                        
        }

        public IActionResult Search(string searchString)
        {           
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                //List<Propietario> propietarios = dbContext.Propietarios.ToList();
                List<Multas> multas = dbContext.Multas.ToList();
                List<Vehiculo> vehiculos = dbContext.Vehiculo.ToList();

                var searchMultas = from e in dbContext.Multas 
                                   join d in multas on e.Idnit equals d.IdMulta into table1
                                   //from d in table1.ToList()
                                   join i in vehiculos on table1. equals i.TipoPlaca into table2
                                   from i in table2.ToList()
                                  
                                   select new 
                                   {                                       
                                       multas = e,
                                       vehiculo = d,
                                       nit = i
                                   };
                return PartialView(searchMultas);
            }

            /*var searchMultas = dbContext.Multas;
            int searchInt = Convert.ToInt32(searchString);

            if (!String.IsNullOrEmpty(searchString))
            {
                this.dbContext.Multas.Where(x => x.Idnit == searchInt);
                searchString = dbContext.Find();
            }

            return PartialView(await searchMultas.ToListAsync());*/
        }

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
