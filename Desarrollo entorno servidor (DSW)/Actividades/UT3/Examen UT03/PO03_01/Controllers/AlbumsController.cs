using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PO03_01.Data;
using PO03_01.Models;

namespace PO03_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AlbumsController : ControllerBase
    {
        private readonly ChinookContext _context;

        public AlbumsController(ChinookContext context)
        {
            _context = context;
        }

        // Listado de todas los albums
        // GET: api/Albums
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Album>>> GetAlbums()
        {
          if (_context.Albums == null)
          {
              return NotFound();
          }

          var Albums = await _context.Albums
                .Include(e => e.Artist)
                .Include(a => a.Pedidos)
                .OrderBy(p => p.Title)
                .Take(15)
                .ToListAsync();

            return Ok(Albums);
        }


        // Detalles de un album junto el artista y los pedidos asociados
        // GET: api/Albums/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Album>> GetAlbum(int id)
        {
          if (_context.Albums == null)
          {
              return NotFound();
          }

            var album = await _context.Albums
                .Include(e => e.Artist)
                .Include(a => a.Pedidos)
                .FirstOrDefaultAsync(g => g.AlbumId == id);

            if (album == null)
            {
                return NotFound();
            }

            return Ok(album);
        }

        private bool AlbumExists(int id)
        {
            return (_context.Albums?.Any(e => e.AlbumId == id)).GetValueOrDefault();
        }
    }
}
