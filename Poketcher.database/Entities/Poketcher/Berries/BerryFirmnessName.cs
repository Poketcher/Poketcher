using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Berries
{
    public class BerryFirmnessName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int BerryFirmnessId { get; set; }
        public BerryFirmness BerryFirmness { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

    }
}
