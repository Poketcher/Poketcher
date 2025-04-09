using Poketcher.database.DBContext;
using Poketcher.database.Entities.User;
using Poketcher.database.Repositories.Base;
using Poketcher.database.Repositories.User.Int;

namespace Poketcher.database.Repositories.User.Imp
{
    public class UserPokemonRepository : Repository<UserPokemon>, IUserPokemonRepository
    {
        public UserPokemonRepository(UserDbContext context) : base(context)
        {
        }

        public IQueryable<UserPokemon> GetUserPokemons(int pageNumber, int pageSize)
        {
            var query = GetAll();

            query = query.Skip(pageNumber * pageSize).Take(pageSize);

            return query;
        }

        public IQueryable<UserPokemon> GetUserPokemonsCaughtAndUncaught(int pageNumber, int pageSize, bool IsCaught)
        {
            var query = GetAll();

            query = query.Where(x => x.IsCaught == IsCaught).Skip(pageNumber * pageSize).Take(pageSize);

            return query;
        }
    }
}
