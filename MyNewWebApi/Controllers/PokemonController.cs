using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyNewWebApi.Models;

namespace MyNewWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly AppDBContext _context;

        public PokemonController(AppDBContext context)
        {
            _context = context;
        }

        // GET: api/Pokemon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemons()
        {
            return await _context.Pokemons.ToListAsync();
        }

        [HttpGet]
        [Route("Electric")]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetElectricPokemon()
        {
            return await _context.Pokemons.Where(p => p.Type.ToLower() == "electric" || p.Type2.ToLower() == "electric").ToListAsync();
        }
        
        [HttpGet]
        [Route("Electric/Count")]
        public async Task<ActionResult<int>> GetElectricPokemonCount()
        {
            return await _context.Pokemons.Where(p => p.Type.ToLower() == "electric" || p.Type2.ToLower() == "electric").CountAsync();
        }

		[HttpGet]
		[Route("Water")]
		public async Task<ActionResult<IEnumerable<Pokemon>>> GetWaterPokemon()
		{
			return await _context.Pokemons.Where(p => p.Type.ToLower() == "water" || p.Type2.ToLower() == "water").ToListAsync();
		}
        
        [HttpGet]
        [Route("Water/Count")]
        public async Task<ActionResult<int>> GetWaterPokemonCount()
        {
            return await _context.Pokemons.Where(p => p.Type.ToLower() == "water" || p.Type2.ToLower() == "water").CountAsync();
        }

		[HttpGet]
		[Route("Fire")]
		public async Task<ActionResult<IEnumerable<Pokemon>>> GetFirePokemon()
		{
			return await _context.Pokemons.Where(p => p.Type.ToLower() == "fire" || p.Type2.ToLower() == "fire").ToListAsync();
		}
        
        [HttpGet]
        [Route("Fire/Count")]
        public async Task<ActionResult<int>> GetFirePokemonCount()
        {
            return await _context.Pokemons.Where(p => p.Type.ToLower() == "fire" || p.Type2.ToLower() == "fire").CountAsync();
        }

		[HttpGet]
		[Route("Ground")]
		public async Task<ActionResult<IEnumerable<Pokemon>>> GetGroundPokemon()
		{
			return await _context.Pokemons.Where(p => p.Type.ToLower() == "ground" || p.Type2.ToLower() == "ground").ToListAsync();
		}
        
        [HttpGet]
        [Route("Ground/Count")]
        public async Task<ActionResult<int>> GetGroundPokemonCount()
        {
            return await _context.Pokemons.Where(p => p.Type.ToLower() == "ground" || p.Type2.ToLower() == "ground").CountAsync();
        }

		[HttpGet]
		[Route("Psychic")]
		public async Task<ActionResult<IEnumerable<Pokemon>>> GetPsychicPokemon()
		{
			return await _context.Pokemons.Where(p => p.Type.ToLower() == "psychic" || p.Type2.ToLower() == "psychic").ToListAsync();
		}
        
        [HttpGet]
        [Route("Psychic/Count")]
        public async Task<ActionResult<int>> GetPsychicPokemonCount()
        {
            return await _context.Pokemons.Where(p => p.Type.ToLower() == "psychic" || p.Type2.ToLower() == "psychic").CountAsync();
        }

		// GET: api/Pokemon/5
		[HttpGet("{id}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int id)
        {
            var pokemon = await _context.Pokemons.FindAsync(id);

            if (pokemon == null)
            {
                return NotFound();
            }

            return pokemon;
        }

        // PUT: api/Pokemon/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPokemon(int id, Pokemon pokemon)
        {
            if (id != pokemon.Id)
            {
                return BadRequest();
            }

			if (pokemon.Type != "electric" || pokemon.Type != "water" || pokemon.Type != "fire" || pokemon.Type != "ground" || pokemon.Type != "psychic" || pokemon.Type2 != "electric" || pokemon.Type2 != "water" || pokemon.Type2 != "fire" || pokemon.Type2 != "ground" || pokemon.Type2 != "psychic")
				return BadRequest();
            
			_context.Entry(pokemon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PokemonExists(id))
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

        // POST: api/Pokemon
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pokemon>> PostPokemon(Pokemon pokemon)
        {
			if (pokemon.Type != "electric" || pokemon.Type != "water" || pokemon.Type != "fire" || pokemon.Type != "ground" || pokemon.Type != "psychic" || pokemon.Type2 != "electric" || pokemon.Type2 != "water" || pokemon.Type2 != "fire" || pokemon.Type2 != "ground" || pokemon.Type2 != "psychic")
				return BadRequest();
			_context.Pokemons.Add(pokemon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPokemon", new { id = pokemon.Id }, pokemon);
        }

        // DELETE: api/Pokemon/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePokemon(int id)
        {
            var pokemon = await _context.Pokemons.FindAsync(id);
            if (pokemon == null)
            {
                return NotFound();
            }

            _context.Pokemons.Remove(pokemon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PokemonExists(int id)
        {
            return _context.Pokemons.Any(e => e.Id == id);
        }
    }
}
