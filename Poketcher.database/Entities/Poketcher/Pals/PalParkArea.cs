using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Pals
{
    public class PalParkArea
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
