using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultasTransito.Data;
using MultasTransito.Models;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MultasTransito.Controllers
{
    public class MunicipiosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MunicipiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Municipios
        public async Task<IActionResult> Index([FromServices] SignInManager<IdentityUser> signInManager)
        {
            if(signInManager.IsSignedIn(User))
            {
                return View(await _context.Municipios.ToListAsync());
            }
            else
            {
                return PartialView("_LoginPartial");
            }
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

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMunicipalidad,Nombre,Direccion,Descripcion,IsChecked")] Municipios municipios)
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
                    //cmd.ExecuteNonQuery();
                    conn.Close();
                    _context.Add(municipios);
                    _context.Add(municipios);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return View(municipios);
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

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMunicipalidad,Nombre,Direccion,Descripcion,IsChecked")] Municipios municipios)
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
