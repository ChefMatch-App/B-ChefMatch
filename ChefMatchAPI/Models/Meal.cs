using System.ComponentModel.DataAnnotations.Schema;

namespace ChefMatchAPI.Models
{
    public class Meal
    {
        public string MealId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public string Ingredients { get; set; }
        public int PortionSize { get; set; }

        public string ChefId { get; set; }
        public Chef Chef { get; set; }

        public OrderItem OrderItem { get; set; }
    }
}
