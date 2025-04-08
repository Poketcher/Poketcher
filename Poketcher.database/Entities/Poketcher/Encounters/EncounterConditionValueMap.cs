using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poketcher.database.Entities.Poketcher.Encounters
{
    public class EncounterConditionValueMap
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Encounter")]
        public int EncounterId { get; set; }
        public Encounter Encounter { get; set; }

        [ForeignKey("EncounterConditionValue")]
        public int EncounterConditionValueId { get; set; }
        public EncounterConditionValue EncounterConditionValue { get; set; }
    }
}
