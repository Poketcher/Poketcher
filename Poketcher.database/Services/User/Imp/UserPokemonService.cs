using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Poketcher.database.Dtos.User;
using Poketcher.database.Entities.User;
using Poketcher.database.Repositories.User.Int;
using Poketcher.database.Services.User.Int;

namespace Poketcher.database.Services.User.Imp
{
    public class UserPokemonService : IUserPokemonService
    {
        private readonly IUserPokemonRepository _repository;
        private readonly IMapper _mapper;

        public UserPokemonService(IUserPokemonRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserPokemonDto>> AllPokemon(int pageNumber, int pageSize)
        {
            var userPokemons = await _repository.GetUserPokemons(pageNumber, pageSize).ToListAsync();
            return _mapper.Map<IEnumerable<UserPokemonDto>>(userPokemons);
        }

        public async Task<IEnumerable<UserPokemonDto>> PokemonCaughtAndUncaught(int pageNumber, int pageSize, bool IsCaught)
        {
            var userPokemons = await _repository.GetUserPokemonsCaughtAndUncaught(pageNumber, pageSize, IsCaught).ToListAsync();
            return _mapper.Map<IEnumerable<UserPokemonDto>>(userPokemons);
        }

        public async Task<UserPokemonDto> Pokemon(int userPokemonId)
        {
            var userPokemon = await _repository.GetById(userPokemonId).FirstOrDefaultAsync();
            if (userPokemon == null)
            {
                throw new KeyNotFoundException($"UserPokemon with ID {userPokemonId} was not found.");
            }
            return _mapper.Map<UserPokemonDto>(userPokemon);
        }

        public CreateUserPokemonDto AddPokemon(CreateUserPokemonDto userPokemonDto)
        {
            var userPokemon = _mapper.Map<UserPokemon>(userPokemonDto);
            _repository.Add(userPokemon);
            _repository.SaveChanges();
            return userPokemonDto;
        }

        public async Task UpdatePokemon(int userPokemonId, UpdateUserPokemonDto updateUserPokemonDto)
        {
            var userPokemon = await _repository.GetById(userPokemonId).FirstOrDefaultAsync();
            if (userPokemon == null)
            {
                throw new KeyNotFoundException($"UserPokemon with ID {userPokemonId} was not found.");
            }

            _mapper.Map(updateUserPokemonDto, userPokemon);
            _repository.Update(userPokemon);
            _repository.SaveChanges();
        }

        public async Task DeletePokemon(int userPokemonId)
        {
            var userPokemon = await _repository.GetById(userPokemonId).FirstOrDefaultAsync();
            if (userPokemon == null)
            {
                throw new KeyNotFoundException($"UserPokemon with ID {userPokemonId} was not found.");
            }

            _repository.Delete(userPokemon);
            _repository.SaveChanges();
        }
    }
}
