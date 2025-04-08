using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonCrie
    {
        [Key]
        public int Id { get; set; }
        public string Latest { get; set; }
        public string Legacy { get; set; }

        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
