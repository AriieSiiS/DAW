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


namespace AUT02_05.Controllers
{
    [Authorize]
    public class FrasesController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly DiccionarioContext _context;

        public FrasesController(DiccionarioContext context, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: Frases
        public async Task<IActionResult> Index()
        {
            var diccionarioContext = _context.Frases.Include(f => f.Espeng);
            return View(await diccionarioContext.ToListAsync());
        }

        // GET: Frases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Frases == null)
            {
                return NotFound();
            }

            var frases = await _context.Frases
                .Include(f => f.Espeng)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (frases == null)
            {
                return NotFound();
            }

            return View(frases);
        }

        // GET: Frases/Create
        public IActionResult Create(int id)
        {
            var espeng = _context.Espengs.Where(e => e.id == id).First();
            ViewBag.Name = espeng;

            return View();
        }

        // POST: Frases/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Eng,Esp,EspengId")] Frases frases, int id)
        {
            frases.EspengId = id;
            if (ModelState.IsValid)
            {
                //sacamos el id del usuario y se lo asignamos a la frase
                var userId = _userManager.GetUserName(User);
                frases.UserId = userId;

                _context.Add(frases);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Espengs", new { id = id });

            }
            return View(frases);
        }

        // GET: Frases/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null || _context.Frases == null)
            {
                return NotFound();
            }

            var frases = await _context.Frases
                .Include(f => f.Espeng)
                .FirstOrDefaultAsync(f => f.Id == id);

            if (frases == null)
            {
                return NotFound();
            }


            return View(frases);
        }

        [Authorize(Roles = "admin")]
        // POST: Frases/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Eng,Esp,EspengId,UserId")] Frases frases)
        {
            if (id != frases.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(frases);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FrasesExists(frases.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Espengs");
            }
            return View(frases);
        }

        [Authorize(Roles = "admin")]
        // GET: Frases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Frases == null)
            {
                return NotFound();
            }

            var frases = await _context.Frases
                .Include(f => f.Espeng)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (frases == null)
            {
                return NotFound();
            }

            return View(frases);
        }

        [Authorize(Roles = "admin")]
        // POST: Frases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Frases == null)
            {
                return Problem("Entity set 'DiccionarioContext.Frases'  is null.");
            }
            var frases = await _context.Frases.FindAsync(id);
            if (frases != null)
            {
                _context.Frases.Remove(frases);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Espengs");
        }

        private bool FrasesExists(int id)
        {
          return (_context.Frases?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
