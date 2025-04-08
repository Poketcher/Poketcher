using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Contests;

namespace Poketcher.database.Entities.Poketcher.Berries
{
    public class BerryFlavour
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int ContestTypeId { get; set; }
        public ContestType ContestType { get; set; }
    }
}
