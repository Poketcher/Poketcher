using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Generations;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class Ability
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public bool IsMainSeries { get; set; }

        [Required]
        public int GenerationId { get; set; }
        public required Generation Generation {  get; set; } 
    }
}
