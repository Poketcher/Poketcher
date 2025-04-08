using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Moves
{
    public class MoveMeta
    {
        [Key]
        public int Id { get; set; }
        public int MinHits { get; set; }
        public int MaxHits { get; set; }
        public int MinTurns { get; set; }
        public int MaxTurns { get; set; }
        public int AilmentChance { get; set; }
        public int FlinchChance { get; set; }
        public int StatChance { get; set; }
        public int Drain { get; set; }
        public int Healing { get; set; }

        public int MoveMetaCategoryId { get; set; }
        public MoveMetaCategory MoveMetaCategory { get; set; }

        public int MoveId { get; set; }
        public Move Move { get; set; }

        public int MoveMetaAlimentId { get; set; }
        public MoveMetaAliment MoveMetaAliment { get; set; }
    }
}
