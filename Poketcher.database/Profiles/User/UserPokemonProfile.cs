using AutoMapper;
using Poketcher.database.Dtos.User;
using Poketcher.database.Entities.User;

namespace Poketcher.database.Profiles.User
{
    public class UserPokemonProfile : Profile
    {
        public UserPokemonProfile() 
        {
            CreateMap<UserPokemon, UserPokemonDto>();
            CreateMap<CreateUserPokemonDto, UserPokemon>();
            CreateMap<UpdateUserPokemonDto, UserPokemon>();
        }
    }
}
