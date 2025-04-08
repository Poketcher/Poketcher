using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonSprite
    {
        [Key]
        public int Id { get; set; }

        public int PokemonId { get; set; }
        public virtual Pokemon Pokemon { get; set; }

        public int? OtherVersionId { get; set; }
        public virtual OtherVersion OtherVersion { get; set; }

        public int? VersionGroupId { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }

        public string FrontDefault { get; set; }
        public string FrontShiny { get; set; }
        public string FrontFemale { get; set; }
        public string FrontShinyFemale { get; set; }

        public string BackDefault { get; set; }
        public string BackShiny { get; set; }
        public string BackFemale { get; set; }
        public string BackShinyFemale { get; set; }
    }
}
