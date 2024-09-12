namespace ChefMatchAPI.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string Address { get; set; }
        public DateOnly Date { get; set; }
        public string Status { get; set; }
        public float Price { get; set; }
        
        public string ClientId { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> OrderItems { get; set; }
        public List<Promotion> Promotions { get; set; }

        public Delivery Delivery { get; set; }
    }
}
