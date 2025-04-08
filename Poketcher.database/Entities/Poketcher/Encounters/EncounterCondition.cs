using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Encounters
{
    public class EncounterCondition
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
