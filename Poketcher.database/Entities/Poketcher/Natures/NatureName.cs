using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Natures
{
    public class NatureName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int NatureId { get; set; }
        public Nature Nature { get; set; }
    }
}
