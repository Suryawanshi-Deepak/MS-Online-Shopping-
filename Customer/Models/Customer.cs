using System.ComponentModel.DataAnnotations;

namespace CustomerAPI.Models
{
    public class Customer
    {
        [Required]
        [Key]
        public int UserID { get; set; }

        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? ContactNumber { get; set; }

        [Required]
        public string? UserType { get; set; }

        [Required]
        [StringLength(200)]
        public string? Address { get; set; }
    }
}
