using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Contests
{
    public class ContestTypeName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Flavor { get; set; }
        public string Color { get; set; }

        public int ContestTypeId { get; set; }
        public ContestType ContestType { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
