using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AUT02_05.Data;
using AUT02_05.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Data.SqlClient;

namespace AUT02_05.Controllers
{
    [Authorize]
    public class EspengsController : Controller
    {
        private readonly DiccionarioContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public EspengsController(DiccionarioContext context, UserManager<IdentityUser> userManager)
        {
                        _userManager = userManager;
            _context = context;
        }

        // GET: Espengs
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["FrasesSortParm"] = sortOrder == "frases_desc" ? "frases_asc" : "frases_desc";
            ViewData["EspSortParm"] = sortOrder == "esp_desc" ? "esp_asc" : "esp_desc";
            ViewData["IngSortParm"] = sortOrder == "ing_desc" ? "ing_asc" : "ing_desc";

            ViewData["CurrentFilter"] = searchString;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var espengs = from s in _context.Espengs
                          select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                espengs = espengs.Where(s => s.ing.Contains(searchString)
                                       || s.esp.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "frases_desc":
                    espengs = espengs.OrderByDescending(s => s.Frases.Count());
                    break;
                case "frases_asc":
                    espengs = espengs.OrderBy(s => s.Frases.Count());
                    break;
                case "esp_desc":
                    espengs = espengs.OrderByDescending(s => s.esp);
                    break;
                case "esp_asc":
                    espengs = espengs.OrderBy(s => s.esp);
                    break;
                case "ing_desc":
                    espengs = espengs.OrderByDescending(s => s.ing);
                    break;
                default:
                    espengs = espengs.OrderBy(s => s.ing);
                    break;
            }
            espengs = espengs.Include(e => e.Frases);

            int pageSize = 30;
            return View(await PaginatedList<Espeng>.CreateAsync(espengs.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        // GET: Espengs/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null || _context.Espengs == null)
            {
                return NotFound();
            }

            var espeng = await _context.Espengs
                .Include(e => e.Frases)
                .FirstOrDefaultAsync(e => e.id == id);
            


            if (espeng == null)
            {
                return NotFound();
            }

            return View(espeng);
        }
        [Authorize(Roles = "admin")]
        // GET: Espengs/Create
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "admin")]
        // POST: Espengs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,esp,ing")] Espeng espeng)
        {
            if (ModelState.IsValid)
            {
                _context.Add(espeng);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(espeng);
        }
        [Authorize(Roles = "admin")]
        // GET: Espengs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Espengs == null)
            {
                return NotFound();
            }

            var espeng = await _context.Espengs.FindAsync(id);
            if (espeng == null)
            {
                return NotFound();
            }
            return View(espeng);
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,esp,ing")] Espeng espeng)
        {
            if (id != espeng.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(espeng);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EspengExists(espeng.id))
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
            return View(espeng);
        }

        [Authorize(Roles = "admin")]
        // GET: Espengs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Espengs == null)
            {
                return NotFound();
            }

            var espeng = await _context.Espengs
                .FirstOrDefaultAsync(m => m.id == id);
            if (espeng == null)
            {
                return NotFound();
            }

            return View(espeng);
        }

        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Espengs == null)
            {
                return Problem("Entity set 'DiccionarioContext.Espengs'  is null.");
            }
            var espeng = await _context.Espengs.FindAsync(id);
            if (espeng != null)
            {
                _context.Espengs.Remove(espeng);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EspengExists(int id)
        {
          return (_context.Espengs?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
