using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Berries
{
    public class BerryFlavourName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int BerryFlavourId { get; set; }
        public BerryFlavour BerryFlavour { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
