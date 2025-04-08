using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Locations
{
    public class LocationArea
    {
        [Key] 
        public int Id { get; set; }
        public int GameIndex { get; set; }
        public string Name { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
