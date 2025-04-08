using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Languages;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class AbilityFlavorText
    {
        [Key]
        public int Id { get; set; }
        public string FlavorText {  get; set; }

        public int AbilityId { get; set; }
        public Ability Ability { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}
