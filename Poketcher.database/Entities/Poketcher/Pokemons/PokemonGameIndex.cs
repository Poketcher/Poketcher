using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonGameIndex
    {
        [Key]
        public int Id { get; set; }
        public int GameIndex { get; set; }

        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }

        public int VersionId { get; set; }
        public Version Version { get; set; }
    }
}
