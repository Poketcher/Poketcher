using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Contests
{
    public class ContestEffectFlavourText
    {
        [Key]
        public int Id { get; set; }
        public string FlavorText { get; set; }

        public int ContestEffectId { get; set; }
        public ContestEffect ContestEffect { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
