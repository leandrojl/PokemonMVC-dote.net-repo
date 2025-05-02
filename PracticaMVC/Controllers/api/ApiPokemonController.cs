using Microsoft.AspNetCore.Mvc;
using MVC.Entidades;
using MVC.Servicio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PracticaMVC.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiPokemonController : ControllerBase

    {

        private IPokemonServicio _pokemonServicio;

        public ApiPokemonController(IPokemonServicio pokemonServicio)
        {
            _pokemonServicio = new PokemonServicio();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pokemon>> Get()
        {
            var pokemons = _pokemonServicio.ObtenerPokemones();
            return Ok(pokemons);
        }



        [HttpPost]
        public ActionResult agregarPokemon([FromBody] Pokemon pokemon)
        {
            if (pokemon == null)
            {
                return BadRequest("Pokemon no puede ser nulo");
            }
            _pokemonServicio.AgregarPokemon(pokemon);
            return CreatedAtAction(nameof(Get), new { nombre = pokemon.nombre }, pokemon);
        }

    }
}
