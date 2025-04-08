using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonHabitat
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
