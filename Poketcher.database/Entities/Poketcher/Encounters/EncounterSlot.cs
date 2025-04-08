using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Encounters
{
    public class EncounterSlot
    {
        [Key]
        public int Id { get; set; }
        public int Slot { get; set; }
        public int Rarity { get; set; }

        public int EncounterMethodId { get; set; }
        public EncounterMethod EncounterMethod { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}
