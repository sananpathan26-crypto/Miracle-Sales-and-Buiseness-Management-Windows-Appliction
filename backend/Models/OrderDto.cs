namespace backend.Models
{
    //public class OrderDto
    //{
    //    public string CustomerName { get; set; }
    //    public string Mobile { get; set; }
    //    public string Email { get; set; }
    //    public string Address { get; set; }
    //    public string ProductName { get; set; }
    //    public decimal Price { get; set; }
    //    public int Quantity { get; set; }
    //    public string PaymentMode { get; set; }
    //}

    public class OrderDto
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Mobile { get; set; }

       public string Email { get; set; }

        public string Address { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string PaymentMode { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsNew { get; set; }
    }

}
