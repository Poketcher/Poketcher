using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Moves
{
    public class MoveChange
    {
        [Key]
        public int Id { get; set; }
        public int Power { get; set; }
        public int PP { get; set; }
        public int Accuracy { get; set; }
        public int MoveEffectChance { get; set; }

        public int MoveId { get; set; }
        public Move Move { get; set; }

        public int MoveEffectId { get; set; }
        public MoveEffect MoveEffect { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}
