using System.ComponentModel.DataAnnotations;

namespace ChefMatchAPI.Models
{
    public class Chef : ApplicationUser
    {
        public string ChefId { get; set; }
        [Range(0, 5)]
        public float Rate { get; set; }
        public string Status { get; set; }
        [Required]
        public string CusinieSpeciality { get; set; }

        public List<Meal> Meals { get; set; }
        public List<QualityCheck> QualityChecks { get; set; }

        public Feedback Feedback { get; set; }
    }
}
