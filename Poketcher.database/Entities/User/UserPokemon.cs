using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.User
{
    public class UserPokemon : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int PokemonNumber { get; set; }
        public int Game { get; set; }
        public bool IsShiny { get; set; }
        public bool IsMale { get; set; }
        public bool IsCaught { get; set; }
    }
}
