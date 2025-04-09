namespace Poketcher.database.Dtos.User
{
    public class UserPokemonDto
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int Generation { get; set; }
        public bool IsShiny { get; set; }
        public bool IsMale { get; set; }
        public bool IsCaught { get; set; }
    }
}
