using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Abilities;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonAbility
    {
        [Key]
        public int Id { get; set; }
        public bool IsHidden { get; set; }
        public int Slot { get; set; }

        public int AbilityId { get; set; }
        public Ability Ability { get; set; }

        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
