using Poketcher.database.Dtos.User;

namespace Poketcher.database.Services.User.Int
{
    public interface IUserPokemonService
    {
        public Task<IEnumerable<UserPokemonDto>> AllPokemon(int pageNumber, int pageSize);
        public Task<IEnumerable<UserPokemonDto>> PokemonCaughtAndUncaught(int pageNumber, int pageSize, bool IsCaught);
        public Task<UserPokemonDto> Pokemon(int UserPokemonId);
        public CreateUserPokemonDto AddPokemon(CreateUserPokemonDto UserPokemon);
        public Task UpdatePokemon(int UserPokemonId, UpdateUserPokemonDto UpdateUserPokemonDto);
        public Task DeletePokemon(int UserPokemonId);
    }
}
