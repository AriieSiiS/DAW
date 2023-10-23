using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AUT02_04.Data;
using AUT02_04.Models;

namespace AUT02_04.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ChinookContext _context;

        public ReviewsController(ChinookContext context)
        {
            _context = context;
        }
        // GET: Reviews/Create
        public async Task<IActionResult> Create(int id)
        {
            var artist = await _context.Artists.FirstOrDefaultAsync(a => a.ArtistId == id);

            if (artist == null)
            {
                return NotFound();
            }

            var model = new Review
            {
                ArtistId = id 
            };

            return View(model);
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Description,Value,ArtistId")] Review review, int Id)
        {
            if (ModelState.IsValid)
            {
                review.ArtistId = Id;
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Artists", new { id = Id });

            }

            return View(review);
        }
    }
}
