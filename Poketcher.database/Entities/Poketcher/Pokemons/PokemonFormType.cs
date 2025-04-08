using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonFormType
    {
        [Key]
        public int Id { get; set; }
        public int Slot { get; set; }

        public int PokemonFormId { get; set; }
        public PokemonForm PokemonForm { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }
    }
}
