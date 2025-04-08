using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Moves
{
    public class MoveEffectText
    {
        [Key]
        public int Id { get; set; }
        public string Effect { get; set; }
        public string ShortEffect { get; set; }

        public int LangaugeId { get; set; }
        public Language Language { get; set; }

        public int MoveEffectId { get; set; }
        public MoveEffect MoveEffect { get; set; }
    }
}
