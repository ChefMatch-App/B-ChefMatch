using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ChefMatchAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(250)]
        public string FirstName { get; set; }
        [Required, MaxLength(250)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Bio { get; set; }
        public DateOnly DateJoined { get; set; }
        public byte[] ProfilePicture { get; set; }
    }
}
