using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.SuperContests
{
    public class SuperContestEffect
    {
        [Key] 
        public int Id { get; set; }
        public int Appeal { get; set; }
    }
}
