using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class Ability
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsMainSeries { get; set; }

        public int GenerationId { get; set; }
        public Generation Generation {  get; set; } 
    }
}
