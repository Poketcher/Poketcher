using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Regions;

namespace Poketcher.database.Entities.Poketcher.Generations
{
    public class Generation
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }

        public int RegionId { get; set; }
        public required Region Region { get; set; }
    }
}
