using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poketcher.database.Entities.Poketcher.Languages
{
    public class LanguageName
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public Language Language { get; set; }

        [ForeignKey("LocalLanguage")]
        public int LocalLanguageId { get; set; }
        public Language LocalLanguage { get; set; }
    }
}

