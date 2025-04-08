using System.ComponentModel.DataAnnotations;
using Poketcher.database.Entities.Poketcher.Items;
using Poketcher.database.Entities.Poketcher.Moves;
using Poketcher.database.Entities.Poketcher.Versions;

namespace Poketcher.database.Entities.Poketcher.Machines
{
    public class Machine
    {
        [Key] 
        public int Id { get; set; }
        public int MachineNumber { get; set; }

        public int MoveId { get; set; }
        public Move Move { get; set; }

        public int VersionGroupId { get; set; }
        public VersionGroup VersionGroup { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
