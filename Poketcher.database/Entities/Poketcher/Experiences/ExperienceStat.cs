using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Growths;

namespace Poketcher.database.Entities.Poketcher.Experiences
{
    public class ExperienceStat
    {
        [Key] 
        public int Id { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public int GrowthRateId { get; set; }
        public GrowthRate GrowthRate { get; set; }
    }
}
