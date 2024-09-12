using System.ComponentModel.DataAnnotations;

namespace ChefMatchAPI.Models
{
    public class Feedback
    {
        public string FeedbackId { get; set; }
        [Range(0, 5)]
        public float Rate { get; set; }
        public DateOnly ReviewDate { get; set; }
        public string? Suggestion { get; set; }
        public int FoodQuality { get; set; }
        public int CleanessQuality { get; set; }
        public int ServiceQuality { get; set; }

        public string ClientId { get; set; }
        public Client Client { get; set; }

        public string ChefId { get; set; }
        public Chef Chef { get; set; }
    }
}
