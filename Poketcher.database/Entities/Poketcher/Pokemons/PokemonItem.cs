using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Items;
using Version = Poketcher.database.Entities.Poketcher.Versions.Version;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonItem
    {
        [Key]
        public int Id { get; set; }
        public int Rarity { get; set; }

        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }

        public int VersionId { get; set; }
        public Version Version { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
