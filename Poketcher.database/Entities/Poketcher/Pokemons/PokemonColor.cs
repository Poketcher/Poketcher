using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonColor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
