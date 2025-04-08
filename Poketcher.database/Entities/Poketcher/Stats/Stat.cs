using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Moves;

namespace Poketcher.database.Entities.Poketcher.Stats
{
    public class Stat
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsBattleOnly { get; set; }
        public int GameIndex { get; set; }

        public int MoveDamageClassId { get; set; }
        public MoveDamageClass MoveDamageClass { get; set; }
    }
}
