using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Locations;
using Poketcher.database.Entities.Poketcher.Pokemons;
using Version = Poketcher.database.Entities.Poketcher.Versions.Version;

namespace Poketcher.database.Entities.Poketcher.Encounters
{
    public class Encounter
    {
        [Key]
        public int Id { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }

        public int LocationAreaId { get; set; }
        public LocationArea LocationArea { get; set; }

        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }

        public int VersionId { get; set; }
        public Version Version { get; set; }

        public int EncounterSlotId { get; set; }
        public EncounterSlot EncounterSlot { get; set; }
    }
}
