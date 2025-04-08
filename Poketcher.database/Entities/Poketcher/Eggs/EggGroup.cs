using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Eggs
{
    public class EggGroup
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
