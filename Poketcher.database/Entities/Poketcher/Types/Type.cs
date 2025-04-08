using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Generations;
using Poketcher.database.Entities.Poketcher.Moves;

namespace Poketcher.database.Entities.Poketcher.Types
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int GenerationId { get; set; }
        public Generation Generation { get; set; }

        public int MoveDamageClassId { get; set; }
        public MoveDamageClass MoveDamageClass { get; set; }
    }
}
