using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Berries;
using Poketcher.database.Entities.Poketcher.Stats;

namespace Poketcher.database.Entities.Poketcher.Natures
{
    public class Nature
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        
        public int HateFlavorId { get; set; }
        public int LikeFlavorId { get; set; }

        [ForeignKey("HateFlavorId")]
        public BerryFlavour HateFlavor { get; set; }

        [ForeignKey("LikeFlavorId")]
        public BerryFlavour LikeFlavor { get; set; }

        public int GameIndex { get; set; }

       
        public int DecresedStatId { get; set; }
        public int IcreasedStatId { get; set; }

        [ForeignKey("DecresedStatId")]
        public Stat DecreasedStat { get; set; }

        [ForeignKey("IcreasedStatId")]
        public Stat IncreasedStat { get; set; }
    }
}
