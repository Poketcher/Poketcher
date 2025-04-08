using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Items
{
    public class ItemSprite
    {
        [Key]
        public int Id { get; set; }

        public int ItemId { get; set; }
        public virtual Item Item { get; set; }

        public int? OtherVersionId { get; set; }
        public virtual OtherVersion OtherVersion { get; set; }

        public int? VersionGroupId { get; set; }
        public virtual VersionGroup VersionGroup { get; set; }

        public string Sprite { get; set; }
    }
}
