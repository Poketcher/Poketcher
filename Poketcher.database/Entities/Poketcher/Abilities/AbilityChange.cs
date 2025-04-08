using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Abilities
{
    public class AbilityChange
    {
        [Key]
        public int Id { get; set; }

        public int AbilityId { get; set; }
        public Ability Ability { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}
