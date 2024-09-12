namespace ChefMatchAPI.Models
{
    public class Payment
    {
        public string PaymentId { get; set; }
        public string Method { get; set; }
        public string Status { get; set; }
        public DateOnly Date { get; set; }

        public string ClientId { get; set; }
        public Client Client { get; set; }
    }
}
