using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Pokeathlons;

namespace Poketcher.database.Entities.Poketcher.Natures
{
    public class NaturePokeathlonStat
    {
        [Key]
        public int Id { get; set; }
        public int MaxChange { get; set; }

        public int NatureId { get; set; }
        public Nature Nature { get; set; }

        public int PokeathlonStatId { get; set; }
        public PokeathlonStat PokeathlonStat { get; set; }
    }
}
