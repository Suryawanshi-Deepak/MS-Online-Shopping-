using System.ComponentModel.DataAnnotations;

namespace CatalogAPI.Models
{
    public class Catalog
    {
        [Required]
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        public bool Availability { get; set; }
    }
}
