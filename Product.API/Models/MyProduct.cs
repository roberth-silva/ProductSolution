using System.ComponentModel.DataAnnotations;

namespace Product.API.Models
{
    public class MyProduct
    {
        [Key]        
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity must be zero or greater")]
        public int StockQuantity { get; set; }
    }
}
