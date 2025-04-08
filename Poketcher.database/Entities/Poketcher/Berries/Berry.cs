using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Items;
using Type = Poketcher.database.Entities.Poketcher.Types.Type;

namespace Poketcher.database.Entities.Poketcher.Berries
{
    public class Berry
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int NaturalPower { get; set; }
        public int Size { get; set; }
        public int MaxHarvest { get; set; }
        public int GrowthTime { get; set; }
        public int SoilDryness { get; set; }
        public int Smoothness { get; set; }

        public int BerryFirmnessId { get; set; }
        public BerryFirmness BerryFirmness { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int NaturalTypeId { get; set; }
        public Type NaturalType { get; set; }
    }
}
