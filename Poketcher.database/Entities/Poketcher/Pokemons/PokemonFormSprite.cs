using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonFormSprite
    {
        [Key]
        public int Id { get; set; }
        public PokemonFormSprites Sprites { get; set; }

        public int PokemonFormId { get; set; }
        public PokemonForm PokemonForm { get; set; }
    }

    public class PokemonFormSprites
    {
        public string BackShiny { get; set; }
        public string BackFemale { get; set; }
        public string FrontShiny { get; set; }
        public string BackDefault { get; set; }
        public string FrontFemale { get; set; }
        public string FrontDefault { get; set; }
        public string BackShinyFemale { get; set; }
        public string FrontShinyFemale { get; set; }
    }

}
