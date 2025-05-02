using Microsoft.AspNetCore.Mvc;
using MVC.Servicio;
using MVC.Entidades;

namespace PracticaMVC.Controllers
{
    public class PokemonController : Controller
    {

        private IPokemonServicio _pokemonServicio;

        public PokemonController(IPokemonServicio pokemonServicio)
        {
            _pokemonServicio = pokemonServicio;
        }   

        public IActionResult Index()
        {
            var pokemons = _pokemonServicio.ObtenerPokemones();

            return View(pokemons);
        }

        public IActionResult Indexxx()
        {
            var pokemons = _pokemonServicio.ObtenerPokemones();

            return View(pokemons);
        }


        public IActionResult AgregarPokemon()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarPokemon(Pokemon pokemon)
        {
            
                _pokemonServicio.AgregarPokemon(pokemon);
                return RedirectToAction("Index");


        }
    }
}
