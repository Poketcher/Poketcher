using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Stats;

namespace Poketcher.database.Entities.Poketcher.Characteristics
{
    public class Characteristic
    {
        [Key] 
        public int Id { get; set; }
        public int GeneMod5 { get; set; }

        public int StatId { get; set; }
        public Stat Stat { get; set; }
    }
}
