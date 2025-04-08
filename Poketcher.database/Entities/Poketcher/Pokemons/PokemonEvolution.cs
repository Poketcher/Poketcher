using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Poketcher.database.Entities.Poketcher.Evolutions;
using Poketcher.database.Entities.Poketcher.Genders;
using Poketcher.database.Entities.Poketcher.Items;
using Poketcher.database.Entities.Poketcher.Moves;
using Location = Poketcher.database.Entities.Poketcher.Locations.Location;

namespace Poketcher.database.Entities.Poketcher.Pokemons
{
    public class PokemonEvolution
    {
        [Key]
        public int Id { get; set; }
        public int MinLevel { get; set; }
        public string TimeOfDay { get; set; }
        public int MinHappiness { get; set; }
        public int MinBeauty { get; set; }
        public int MinAffection { get; set; }
        public int RelativePhysicalStatus { get; set; }
        public bool NeedsOverworldRain { get; set; }
        public bool TurnUpsideDown { get; set; }

        public int EvolutionTriggerId { get; set; }
        public EvolutionTrigger EvolutionTrigger { get; set; }

        [ForeignKey("EvolvedSpecies")]
        public int EvolvedSpeciesId { get; set; }
        public PokemonSpecies EvolvedSpecies { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("KnownMove")]
        public int KnownMoveId { get; set; }
        public Move KnownMove { get; set; }

        [ForeignKey("KnownMoveType")]
        public int KnownMoveTypeId { get; set; }
        public Type KnownMoveType { get; set; }

        [ForeignKey("PartySpecies")]
        public int PartySpeciesId { get; set; }
        public PokemonSpecies PartySpecies { get; set; }

        [ForeignKey("PartyType")]
        public int PartyTypeId { get; set; }
        public Type PartyType { get; set; }

        [ForeignKey("TradeSpecies")]
        public int TradeSpeciesId { get; set; }
        public PokemonSpecies TradeSpecies { get; set; }

        [ForeignKey("EvolutionItem")]
        public int EvolutionItemId { get; set; }
        public Item EvolutionItem { get; set; }

        [ForeignKey("HeldItem")]
        public int HeldItemId { get; set; }
        public Item HeldItem { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
