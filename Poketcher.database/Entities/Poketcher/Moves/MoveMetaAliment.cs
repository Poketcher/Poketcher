using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Moves
{
    public class MoveMetaAliment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
