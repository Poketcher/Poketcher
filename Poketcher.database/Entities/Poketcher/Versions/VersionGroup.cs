using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Generations;

namespace Poketcher.database.Entities.Poketcher.Versions
{
    public class VersionGroup
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order {  get; set; }

        public int GenerationId { get; set; }
        public Generation Generation { get; set; }
    }
}
