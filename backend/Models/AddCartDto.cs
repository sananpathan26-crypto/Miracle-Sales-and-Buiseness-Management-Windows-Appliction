//namespace backend.Models
//{
//    public class AddCartDto
//    {
//        public string ProductId { get; set; }
//        public string ProductName { get; set; }
//        public decimal Price { get; set; }
//        public string ImageUrl { get; set; }
//    }
//}

using System.Text.Json.Serialization;

public class AddCartDto
{
    [JsonPropertyName("productId")]
    public string ProductId { get; set; }

    [JsonPropertyName("productName")]
    public string ProductName { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }

    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; }
}
