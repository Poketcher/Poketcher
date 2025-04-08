using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Contests
{
    public class ContestType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
