using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Eggs
{
    public class EggGroupName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int EggGroupId { get; set; }
        public EggGroup EggGroup { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
