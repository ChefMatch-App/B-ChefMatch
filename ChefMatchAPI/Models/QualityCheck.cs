using System.ComponentModel.DataAnnotations;

namespace ChefMatchAPI.Models
{
    public class QualityCheck
    {
        public string QualityCheckId { get; set; }
        public string InspectorName { get; set; }
        public DateOnly Date { get; set; }
        [Range(0, 5)]
        public float CleanessRate { get; set; }
        [Range(0, 5)]
        public float QualityRate { get; set; }
        public string Comment { get; set; }

        public string ChefId { get; set; }
        public Chef Chef { get; set; }
    }
}
