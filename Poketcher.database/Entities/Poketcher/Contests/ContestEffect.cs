using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Contests
{
    public class ContestEffect
    {
        [Key]
        public int Id { get; set; }
        public int Appeal { get; set; }
        public int Jam { get; set; }
    }
}
