using System.ComponentModel.DataAnnotations.Schema;

namespace ChefMatchAPI.Models
{
    public class Delivery
    {
        public string DeliveryId { get; set; }
        public int ItemsCount { get; set; }
        public string ShippingType { get; set; }
        public int TrackingNumber { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public string DeliveryStatus { get; set; }
        
        public string OrderId { get; set; }

        //[ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
