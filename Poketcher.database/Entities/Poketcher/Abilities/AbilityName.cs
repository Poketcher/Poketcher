using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class AbilityName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int AbilityId { get; set; }
        public Ability Ability { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
