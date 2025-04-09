using Poketcher.database.Entities.User;
using Poketcher.database.Repositories.Base;

namespace Poketcher.database.Repositories.User.Int
{
    public interface IUserPokemonRepository : IRepository<UserPokemon>
    {
        public IQueryable<UserPokemon> GetUserPokemons(int pageNumber, int pageSize);
        public IQueryable<UserPokemon> GetUserPokemonsCaughtAndUncaught(int pageNumber, int pageSize, bool IsCaught);
    }
}
