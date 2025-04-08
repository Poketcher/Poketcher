using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Languages;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonShapeName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string AwesomeName { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        [ForeignKey("PokemonShape")]
        public int ShapeId { get; set; }
        public PokemonShape PokemonShape { get; set; }
    }
}
