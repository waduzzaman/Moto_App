using System.ComponentModel.DataAnnotations;

namespace MvcMoto.Models
{
    public class Moto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "The Name field must be a string with a minimum length of 3 and a maximum length of 60.")]
        public string? Name { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "The Circuit field must be a string with a minimum length of 3 and a maximum length of 60.")]
        public string? Circuit { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "The Team field must be a string with a minimum length of 3 and a maximum length of 60.")]
        public string? Team { get; set; }

        [Required]
        [Display(Name = "World Rank")]
        public int WorldRank { get; set; }

        [Required]
        [Display(Name = "Driver Number")]
        public int DriverNumber { get; set; }

        // For online 
       // public string? ImageUrl { get; set; }
    }
}
