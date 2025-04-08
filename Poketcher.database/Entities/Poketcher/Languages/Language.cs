using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Languages
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        public string Iso639 {  get; set; }
        public string Iso3166 { get; set; }
        public string Name { get; set; }

    }
}
