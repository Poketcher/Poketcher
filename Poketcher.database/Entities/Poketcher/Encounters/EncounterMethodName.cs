using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Encounters
{
    public class EncounterMethodName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int EncounterMethodId { get; set; }
        public EncounterMethod EncounterMethod { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
