using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PO03_01.Data;
using PO03_01.Models;
using System.Security.Claims;

namespace PO03_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PedidosController : ControllerBase
    {
        private readonly ChinookContext _context;
        private readonly UserManager<AppUser> _userManager;

        public PedidosController(UserManager<AppUser> userManager, ChinookContext context)
        {
            _context = context;
            _userManager = userManager;
        }

        // Listado de Pedidos de un comercial
        [HttpGet("ComercialPedidos/{userName}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedido(string userName)
        {
            if (_context.Pedido == null)
            {
                return NotFound();
            }
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            var pedidos = await _context.Pedido
                .Where(p => p.ComercialId == user.Id)
                .ToListAsync();

            return Ok(pedidos);
        }


        // Detalle de un pedido junto con la información del album para quien fue creado
        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            if (_context.Pedido == null)
            {
                return NotFound();
            }
            var pedido = await _context.Pedido
                .Include(a => a.Album)
                .FirstOrDefaultAsync(g => g.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }

            return Ok(pedido);
        }

        // Edición de un pedido
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPedido(int id, Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return BadRequest();
            }

            _context.Entry(pedido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // Creación de un pedido para un album
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Pedido>> PostPedido(Pedido pedido)
        {
            var userName = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            if (user.isActive == false)
            {
                return Forbid();
            }

            if (_context.Pedido == null)
            {
                return Problem("Entity set 'ChinookContext.Pedido'  is null.");
            }

            pedido.ComercialId = user.Id;

            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPedido", new { id = pedido.Id }, pedido);
        }



        // Eliminación de un pedido.
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePedido(int id)
        {
            if (_context.Pedido == null)
            {
                return NotFound();
            }
            var pedido = await _context.Pedido.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }

            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PedidoExists(int id)
        {
            return (_context.Pedido?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
