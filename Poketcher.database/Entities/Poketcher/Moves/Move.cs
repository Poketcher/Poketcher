using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Contests;
using Poketcher.database.Entities.Poketcher.Generations;
using Poketcher.database.Entities.Poketcher.SuperContests;
using Type = Poketcher.database.Entities.Poketcher.Types.Type;

namespace Poketcher.database.Entities.Poketcher.Moves
{
    public class Move
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int PP { get; set; }
        public int Accuracy { get; set; }
        public int Priority { get; set; }
        public int MoveEffectChance { get; set; }

        public int GenerationId { get; set; }
        public Generation Generation { get; set; }

        public int MoveDamegeClassId { get; set; }
        public MoveDamageClass MoveDamegeClass { get; set; }

        public int MoveEffectId { get; set; }
        public MoveEffect MoveEffect { get; set; }

        public int MoveTargetId { get; set; }
        public MoveTarget MoveTarget { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }

        public int ContestEffectId { get; set; }
        public ContestEffect ContestEffect { get; set; }

        public int ContestTypeId { get; set; }
        public ContestType ContestType { get; set; }

        public int SuperContestEffectId { get; set; }
        public SuperContestEffect SuperContestEffect { get; set; }
    }
}
