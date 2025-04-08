using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Stats
{
    public class StatName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int StatId { get; set; }
        public Stat Stat { get; set; }
    }
}
