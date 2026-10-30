using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        public string ImagePath { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
