using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Regions
{
    public class Region
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
