namespace backend.Models
{
    public class OrderViewModel
    {
        public int OrderID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public string PaymentMode { get; set; }
        public string OrderStatus { get; set; }
    }
}
