namespace ChefMatchAPI.Models
{
    public class OrderItem
    {
        public string OrderItemId { get; set; }

        public string OrderId { get; set; }
        public Order Order { get; set; }
        public string MealId { get; set; }
        public Meal Meal { get; set; }

        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
