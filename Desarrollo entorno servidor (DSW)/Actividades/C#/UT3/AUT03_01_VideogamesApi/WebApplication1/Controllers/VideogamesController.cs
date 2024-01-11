using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideogamesController : ControllerBase
    {
        static List<Videogame> videogamesList = new List<Videogame>
        {
            new Videogame { Id = 1, Title = "Juego Estrategia", Genre = "Estrategia" },
            new Videogame { Id = 2, Title = "Juego Deporte", Genre = "Deporte" },
            new Videogame { Id = 3, Title = "Juego Acción", Genre = "Acción" }
        };

        static int id = 4;

        // GET: api/<VideogamesController>
        [HttpGet]
        public IEnumerable<Videogame> Get()
        {
            return videogamesList;
        }

        // GET api/<VideogamesController>/5
        [HttpGet("{id}")]
        public ActionResult<Videogame> Get(int id)
        {
            var videogame = videogamesList.FirstOrDefault(v => v.Id == id);

            if (videogame == null)
            {
                return NotFound();
            }

            return Ok(videogame);
        }

        // POST api/<VideogamesController>
        [HttpPost]
        public ActionResult<Videogame> Post([FromBody] Videogame videogame)
        {
            videogamesList.Add(videogame);
            return CreatedAtAction("Get", new { id = videogame.Id }, videogame);
        }

        // PUT api/<VideogamesController>/5
        [HttpPut("{id}")]
        public ActionResult<Videogame> Put(int id, [FromBody] Videogame updatedVideogame)
        {
            var existingVideogame = videogamesList.FirstOrDefault(v => v.Id == id);

            if (existingVideogame == null)
            {
                return NotFound(); 
            }

            existingVideogame.Title = updatedVideogame.Title;
            existingVideogame.Genre = updatedVideogame.Genre;

            return Ok(existingVideogame);
        }

        // DELETE api/<VideogamesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var videogame = videogamesList.FirstOrDefault(v => v.Id == id);

            if (videogame == null)
            {
                return NotFound(); 
            }

            videogamesList.Remove(videogame);

            return NoContent();
        }

    }
}
