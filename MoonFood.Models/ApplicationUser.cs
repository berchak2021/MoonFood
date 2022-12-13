using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MoonFood.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public string? StreetAddress { get; set; }
    }
}
