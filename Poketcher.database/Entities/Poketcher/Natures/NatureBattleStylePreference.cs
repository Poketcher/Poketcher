using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Moves;

namespace Poketcher.database.Entities.Poketcher.Natures
{
    public class NatureBattleStylePreference
    {
        [Key]
        public int Id { get; set; }
        public int LowHpPreference { get; set; }
        public int HighHpPreference { get; set; }

        public int NatureId { get; set; }
        public Nature Nature { get; set; }

        public int MoveBattleStyleId { get; set; }
        public MoveBattleStyle MoveBattleStyle { get; set; } 
    }
}
