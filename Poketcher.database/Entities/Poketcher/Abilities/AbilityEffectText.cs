using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class AbilityEffectText
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Effect {  get; set; } = string.Empty;
        [Required]
        public string ShortEffect { get; set; } = string.Empty;

        [Required]
        public int AbilityId { get; set; }
        public required Ability Ability { get; set; }

        [Required]
        public int LanguageId { get; set; }
        public required Language Language { get; set; }
    }
}
