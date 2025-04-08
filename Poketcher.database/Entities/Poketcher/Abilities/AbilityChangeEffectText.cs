using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class AbilityChangeEffectText
    {
        [Key]
        public int Id { get; set; }
        public string Effect {  get; set; }

        public int AbilityChangeId { get; set; }
        public AbilityChange AbilityChange { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
