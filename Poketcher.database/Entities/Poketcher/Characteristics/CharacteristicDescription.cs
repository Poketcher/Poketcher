using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Characteristics
{
    public class CharacteristicDescription
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }

        public int CharacteristicId { get; set; }
        public Characteristic Characteristic { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
