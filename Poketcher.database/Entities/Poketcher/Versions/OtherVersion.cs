using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Versions
{
    public class OtherVersion
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
