using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/online-customers")]
    public class OnlineCustomersController : ControllerBase
    {

        private readonly IConfiguration _config;

        public OnlineCustomersController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("with-orders")]
        public IActionResult GetCustomersWithOrders()
        {
            var list = new List<object>();

            using var con = new MySqlConnection(
                _config.GetConnectionString("MySqlConnection"));
            con.Open();

            string query = @"
                SELECT 
                    c.CustomerID,
                    c.CustomerName,
                    c.Mobile,
                    c.Email,
                    o.OrderID,
                    o.ProductName,
                    o.Quantity,
                    o.Price,
                    o.PaymentMode,
                    o.OrderDate
                FROM online_customers c
                JOIN orders o ON c.CustomerID = o.CustomerID
                ORDER BY o.OrderDate DESC";

            using var cmd = new MySqlCommand(query, con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new
                {
                    customerId = reader["CustomerID"],
                    customerName = reader["CustomerName"],
                    mobile = reader["Mobile"],
                    email = reader["Email"],
                    orderId = reader["OrderID"],
                    productName = reader["ProductName"],
                    quantity = reader["Quantity"],
                    price = reader["Price"],
                    paymentMode = reader["PaymentMode"],
                    orderDate = reader["OrderDate"]
                });
            }

            return Ok(list);
        }

    }
}
