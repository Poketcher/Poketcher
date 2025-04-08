using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Generations
{
    public class Generation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
