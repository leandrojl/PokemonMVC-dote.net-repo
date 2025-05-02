using MVC.Entidades;

namespace MVC.Servicio
{
    public interface IPokemonServicio
    {
        List<Pokemon> ObtenerPokemones();

        void AgregarPokemon(Pokemon pokemon);
    }
    public class PokemonServicio : IPokemonServicio
    {
        private static List<Pokemon> _pokemones; //es un atributo estatico, por lo que no se puede modificar desde el controlador

        public PokemonServicio()
        {
            
            if (_pokemones == null)
            {
                _pokemones = new List<Pokemon>();
                AgregarPokemon(new Pokemon
                {
                    nombre = "Pikachu",
                    tipo = "Electrico",
                    imagen = "pikachu.jpg"
                });
            }
                

        }

        public List<Pokemon> ObtenerPokemones()
        {
            

            return _pokemones;
        }

        public void AgregarPokemon(Pokemon pokemon)
        {
            _pokemones.Add(pokemon);
        }
    }
}
