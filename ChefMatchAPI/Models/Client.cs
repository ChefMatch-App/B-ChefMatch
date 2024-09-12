namespace ChefMatchAPI.Models
{
    public class Client : ApplicationUser
    {
        public string ClientId { get; set; }

        public List<Order> Orders { get; set; }
        public List<Payment> Payments { get; set; }

        public Feedback Feedback { get; set; }
    }
}
