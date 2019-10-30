using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultasTransito.Data;
using MultasTransito.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MultasTransito.Controllers
{
    public class MultasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MultasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Multas
        public async Task<IActionResult> Index([FromServices] SignInManager<IdentityUser> signInManager)
        {
            if(signInManager.IsSignedIn(User))
            {
                return View(await _context.Multas.ToListAsync());
            }
            else
            {
                return PartialView("_LoginPartial");
            }            
        }

        // GET: Multas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multas = await _context.Multas
                .FirstOrDefaultAsync(m => m.IdMulta == id);
            if (multas == null)
            {
                return NotFound();
            }

            return View(multas);
        }

        // GET: Multas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Multas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdMulta,IdMunicipalidad,Descripcion,IdPlaca,Idnit")] Multas multas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(multas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(multas);
        }

        // GET: Multas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multas = await _context.Multas.FindAsync(id);
            if (multas == null)
            {
                return NotFound();
            }
            return View(multas);
        }

        // POST: Multas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdMulta,IdMunicipalidad,Descripcion,IdPlaca,Idnit")] Multas multas)
        {
            if (id != multas.IdMulta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(multas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MultasExists(multas.IdMulta))
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
            return View(multas);
        }

        // GET: Multas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var multas = await _context.Multas
                .FirstOrDefaultAsync(m => m.IdMulta == id);
            if (multas == null)
            {
                return NotFound();
            }

            return View(multas);
        }

        // POST: Multas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var multas = await _context.Multas.FindAsync(id);
            _context.Multas.Remove(multas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MultasExists(int id)
        {
            return _context.Multas.Any(e => e.IdMulta == id);
        }
    }
}
