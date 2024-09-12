namespace ChefMatchAPI.Models
{
    public class Promotion
    {
        public string PromotionId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DiscountPercentage { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int MaxLimit { get; set; }
        public int UsageCount { get; set; }

        public string OrderId { get; set; }
        public Order Order { get; set; }
    }
}
