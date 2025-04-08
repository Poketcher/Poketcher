using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Encounters;

namespace Poketcher.database.Entities.Poketcher.Locations
{
    public class LocationAreaEncounterRate
    {
        [Key]
        public int Id { get; set; }
        public int Rate { get; set; }

        public int LocationAreaId { get; set; }
        public LocationArea LocationArea { get; set; }

        public int VersionId { get; set; }
        public Version Version { get; set; }

        public int EncounterMethodId { get; set; }
        public EncounterMethod EncounterMethod { get; set; }
    }
}
