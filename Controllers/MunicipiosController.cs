using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MultasTransito.Data;
using MultasTransito.Models;

namespace MultasTransito.Controllers
{
    public class MunicipiosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MunicipiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult GetMunicipios()
        {
            string[] NombreMunis = { "Guatemala", "Mixco", "Villa Nueva", "San José Pinula", "Fraijanes" };
            ViewBag.NombreMunis = NombreMunis;
            ViewBag.NombreMunisLenght = NombreMunis.Length;
            Municipios municipios = new Municipios();
            this._context.Add(NombreMunis);
            if(NombreMunis == default)
            {
                municipios.MunicipiosSelect = _context.Municipios.ToList<Municipios>();
            }
            return View(municipios);
        }
        // GET: Municipios
        public async Task<IActionResult> Index()
        {
            /*string[] NombreMunis = { "Guatemala", "Mixco", "Villa Nueva", "San José Pinula", "Fraijanes" };
            ViewBag.NombreMunis = NombreMunis;
            ViewBag.NombreMunisLenght = NombreMunis.Length;*/
            /*List<SelectListItem> lst = new List<SelectListItem>
            {
                new SelectListItem() { Text = "Guatemala", Value = "1" },
                new SelectListItem() { Text = "Mixco", Value = "2" },
                new SelectListItem() { Text = "Villa Nueva", Value = "3" },
                new SelectListItem() { Text = "San José Pinula", Value = "4" },
                new SelectListItem() { Text = "Fraijanes", Value = "5" }                
            };           

            IdentityResult result;
            var MuniFlag = serviceProvider.GetRequiredService<Municipios>();
            var Multas = serviceProvider.GetRequiredService<Multas>();
            string[] NombreMunis = { "Guatemala", "Mixco", "Villa Nueva", "San José Pinula", "Fraijanes" };
            ViewBag.Lista = lst;

            foreach (var munis in NombreMunis)    
            {
                var muniExist = await this._context.Municipios.ToListAsync();
                if(muniExist == null)
                {
                    return NotFound();
                }
            }*/
            return View(await _context.Municipios.ToListAsync());
        }

        // GET: Municipios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipios = await _context.Municipios
                .FirstOrDefaultAsync(m => m.IdMunicipalidad == id);
            if (municipios == null)
            {
                return NotFound();
            }

            return View(municipios);
        }

        // GET: Municipios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Municipios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMunicipalidad,Nombre,Direccion,Descripcion")] Municipios municipios)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    SqlConnection conn = (SqlConnection)_context.Database.GetDbConnection();
                    SqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "dbo.sp_ConsultarMultas";
                    cmd.Parameters.Add("@IdMuni", System.Data.SqlDbType.Int).Value = municipios.IdMunicipalidad;
                    cmd.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 32).Value = municipios.Nombre;
                    cmd.Parameters.Add("@Direccion", System.Data.SqlDbType.VarChar, 256).Value = municipios.Direccion;
                    cmd.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar, 256).Value = municipios.Descripcion;                    
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    _context.Add(municipios);                   
                }
                return View(municipios);
            }
            catch(DbUpdateConcurrencyException)
            {
                
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Municipios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipios = await _context.Municipios.FindAsync(id);
            if (municipios == null)
            {
                return NotFound();
            }
            return View(municipios);
        }

        // POST: Municipios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMunicipalidad,Nombre,Direccion,Descripcion")] Municipios municipios)
        {
            if (id != municipios.IdMunicipalidad)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {                    
                    _context.Update(municipios);
                    await _context.SaveChangesAsync();
                }                
                catch (DbUpdateConcurrencyException)
                {
                    if (!MunicipiosExists(municipios.IdMunicipalidad))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(municipios);
        }
        
        // GET: Municipios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var municipios = await _context.Municipios
                .FirstOrDefaultAsync(m => m.IdMunicipalidad == id);
            if (municipios == null)
            {
                return NotFound();
            }

            return View(municipios);
        }

        // POST: Municipios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var municipios = await _context.Municipios.FindAsync(id);
            _context.Municipios.Remove(municipios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MunicipiosExists(int id)
        {
            return _context.Municipios.Any(e => e.IdMunicipalidad == id);
        }
    }
}
