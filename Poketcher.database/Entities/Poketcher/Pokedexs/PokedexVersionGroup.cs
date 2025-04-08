using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Pokedexs
{
    public class PokedexVersionGroup
    {
        [Key]
        public int Id { get; set; }

        public int PokedexId { get; set; }
        public Pokedex Pokedex { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}
