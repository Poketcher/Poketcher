using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class AbilityChangeEffectText
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Effect {  get; set; } = string.Empty;

        [Required]
        public int AbilityChangeId { get; set; }
        public required AbilityChange AbilityChange { get; set; }

        [Required]
        public int LanguageId { get; set; }
        public required Language Language { get; set; }
    }
}
