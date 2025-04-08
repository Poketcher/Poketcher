using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonForm
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string FormName { get; set; }
        public bool IsDefault { get; set; }
        public bool IsBattleOnly { get; set; }
        public bool IsMega { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }

        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }

        public int FormOrder { get; set; }
    }
}
