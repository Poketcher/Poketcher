using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Evolutions
{
    public class EvolutionTrigger
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
