using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Berries
{
    public class BerryFlavourMap
    {
        [Key] 
        public int Id { get; set; }
        public int Potency { get; set; }

        public int BerryId { get; set; }
        public Berry Berry { get; set; }

        public int BerryFlavourId { get; set; }
        public BerryFlavour BerryFlavour { get; set; }
    }
}
