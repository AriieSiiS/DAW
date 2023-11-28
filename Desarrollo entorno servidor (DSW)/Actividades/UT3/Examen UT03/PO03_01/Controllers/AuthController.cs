using PO03_01.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PO03_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<AppUser> userManager,IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpPost("Register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromBody] RegisterUser model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid request. Email and password are required.");
            }

            var user = new AppUser
            {
                UserName = model.Email,
                Email = model.Email,
                FullName = model.FullName,
                isActive = false
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Comercial");
                return Ok("User registered successfully.");
            }

            return BadRequest(result.Errors);
        }



        [HttpPost("Login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login([FromBody] LoginUser model)
        {
            if (model == null || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
            {
                return BadRequest("Invalid request. Email and password are required.");
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            var result = await _userManager.CheckPasswordAsync(user, model.Password);
            var roles = await _userManager.GetRolesAsync(user);

            if (result)
            {
                var claims = new List<Claim>
                {
                    //Identificador único del Token
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    //Fecha de emisión del Token
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    //UserName del usuario
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    // Roles del usuario
                    new Claim(ClaimTypes.Role, string.Join(",", roles))
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    _configuration["Jwt:Issuer"],
                    _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.UtcNow.AddHours(2),
                    signingCredentials: credentials);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }

            return Unauthorized("Invalid email or password.");
        }

        [HttpGet("changeState/{userName}")]
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> changeState(string userName)
        {
            //buscamos el usuario en la base de datos
            var user = await _userManager.FindByNameAsync(userName);

            if (user == null)
            {
                return NotFound("Usuario no encontrado.");
            }

            if (user.isActive == false)
            {
                user.isActive = true;
                await _userManager.UpdateAsync(user);
                return Ok("El usuario ahora está ahora activado.");
            } 
            else
            {
                user.isActive = false;
                await _userManager.UpdateAsync(user);
                return Ok("El usuario ahora está ahora desactivado.");
            }
        }

    }
}

