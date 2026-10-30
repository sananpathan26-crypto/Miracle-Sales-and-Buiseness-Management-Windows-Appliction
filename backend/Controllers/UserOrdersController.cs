using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/userorders")]
    public class UserOrdersController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UserOrdersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("my-orders")]
        public IActionResult GetMyOrders()
        {
            // 🔐 Get logged-in user from session
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return Unauthorized("Not logged in");

            var orders = new List<object>();

            string connStr = _configuration.GetConnectionString("MySqlConnection");

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        OrderID,
                        ProductName,
                        Price,
                        Quantity,
                        (Price * Quantity) AS TotalAmount,
                        OrderDate,
                        PaymentMode,
                        OrderStatus
                    FROM orders
                    WHERE user_id = @UserId
                    ORDER BY OrderDate DESC";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            orders.Add(new
                            {
                                OrderID = reader.GetInt32("OrderID"),
                                ProductName = reader.GetString("ProductName"),
                                Price = reader.GetDecimal("Price"),
                                Quantity = reader.GetInt32("Quantity"),
                                TotalAmount = reader.GetDecimal("TotalAmount"),
                                OrderDate = reader.GetDateTime("OrderDate"),
                                PaymentMode = reader.GetString("PaymentMode"),
                                OrderStatus = reader.GetString("OrderStatus")
                            });
                        }
                    }
                }
            }

            return Ok(orders);
        }
    }
}
