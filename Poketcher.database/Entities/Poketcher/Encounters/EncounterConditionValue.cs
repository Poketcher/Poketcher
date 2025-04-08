using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Encounters
{
    public class EncounterConditionValue
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }

        public int EncounterConditionId { get; set; }
        public EncounterCondition EncounterCondition { get; set; }

    }
}
