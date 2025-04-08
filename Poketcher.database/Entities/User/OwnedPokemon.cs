using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.User
{
    public class OwnedPokemon
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public int Generation { get; set; }
        public bool IsShiny { get; set; }
        public bool IsMale { get; set; }
    }
}
