using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Moves
{
    public class MoveEffectChangeEffectText
    {
        [Key]
        public int Id { get; set; }
        public string Effect { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int MoveEffectChangeId { get; set; }
        public MoveEffectChange MoveEffectChange { get; set; }
    }
}
