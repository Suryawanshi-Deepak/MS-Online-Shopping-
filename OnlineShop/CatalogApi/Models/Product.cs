namespace CatalogApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Availability { get; set; }
    }
}
