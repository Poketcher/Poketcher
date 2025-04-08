using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Moves
{
    public class MoveEffectChange
    {
        [Key]
        public int Id { get; set; }

        public int MoveEffectId { get; set; }
        public MoveEffect MoveEffect { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}
