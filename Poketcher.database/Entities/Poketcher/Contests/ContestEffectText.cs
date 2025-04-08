using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Contests
{
    public class ContestEffectText
    {
        [Key]
        public int Id { get; set; }
        public string Effect { get; set; }

        public int ContestEffectId { get; set; }
        public ContestEffect ContestEffect { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
