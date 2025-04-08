using System.ComponentModel.DataAnnotations;

namespace Poketcher.database.Entities.Poketcher.Items
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int FlingPower { get; set; }

        public int ItemCategoryId { get; set; }
        public ItemCategory ItemCategory { get; set; }

        public int ItemFlingEffectId { get; set; }
        public ItemFlingEffect ItemFlingEffect { get; set; }
    }
}
