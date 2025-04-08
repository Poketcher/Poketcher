using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Pokedexs;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonDexNumber
    {
        [Key]
        public int Id { get; set; }
        public int PokedexNumber { get; set; }

        public int PokedexId { get; set; }
        public Pokedex Pokedex { get; set; }

        public int PokemonSpeciesId { get; set; }
        public PokemonSpecies PokemonSpecies { get; set; }
    }
}
