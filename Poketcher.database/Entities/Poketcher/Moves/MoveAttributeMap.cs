using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Moves
{
    public class MoveAttributeMap
    {
        [Key]
        public int Id { get; set; }

        public int MoveId { get; set; }
        public Move Move { get; set; }

        public int MoveAttributeId { get; set; }
        public MoveAttribute MoveAttribute { get; set; }
    }
}
