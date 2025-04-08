using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Genders
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
