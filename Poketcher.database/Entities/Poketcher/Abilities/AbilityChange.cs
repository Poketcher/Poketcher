using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class AbilityChange
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AbilityId { get; set; }
        public required Ability Ability { get; set; }

        [Required]
        public int VersionGroupId { get; set; }
        public required VersionGroup VersionGroup { get; set; }
    }
}
