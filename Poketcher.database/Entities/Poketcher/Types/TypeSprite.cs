using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Types
{
    public class TypeSprite
    {
        [Key]
        public int Id { get; set; }

        public int TypeId { get; set; }
        public Type Type { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }

        public string Sprite { get; set; }
    }

}
