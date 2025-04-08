using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Versions
{
    public class Version
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }
    }
}
