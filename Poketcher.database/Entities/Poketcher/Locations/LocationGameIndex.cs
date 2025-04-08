using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Generations;

namespace Poketcher.database.Entities.Poketcher.Locations
{
    public class LocationGameIndex
    {
        [Key]
        public int Id { get; set; }
        public int GameIndex { get; set; }

        public int GenerationId { get; set; }
        public Generation Generation { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
