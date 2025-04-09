namespace Poketcher.database.Dtos.User
{
    public class UserPokemonDto
    {
        public int Id { get; set; }
        public int PokemonNumber { get; set; }
        public int Game { get; set; }
        public bool IsShiny { get; set; }
        public bool IsMale { get; set; }
        public bool IsCaught { get; set; }
    }
}
