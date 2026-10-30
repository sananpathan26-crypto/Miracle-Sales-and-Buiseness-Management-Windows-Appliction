using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/online-orders")]
    public class OnlineOrdersController : Controller
    {
        private readonly IConfiguration _config;

        public OnlineOrdersController(IConfiguration config)
        {
            _config = config;
        }

        // GET: api/online-orders/all
        [HttpGet("all")]
        public IActionResult GetOrders()
        {
            var list = new List<object>();

            using var con = new MySqlConnection(
                _config.GetConnectionString("MySqlConnection"));
            con.Open();

            string query = @"
                SELECT 
                    o.OrderID,
                    c.CustomerName,
                    c.Mobile,
                    o.ProductName,
                    o.Quantity,
                    o.Price,
                    o.PaymentMode,
                    o.OrderDate,
                    o.IsNew,
                    IFNULL(o.OrderStatus, 'Pending') AS OrderStatus
                FROM orders o
                JOIN online_customers c ON o.CustomerID = c.CustomerID
                ORDER BY o.OrderDate DESC";

            using var cmd = new MySqlCommand(query, con);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new
                {
                    orderId = reader["OrderID"],
                    customerName = reader["CustomerName"],
                    mobile = reader["Mobile"],
                    productName = reader["ProductName"],
                    quantity = reader["Quantity"],
                    price = reader["Price"],
                    paymentMode = reader["PaymentMode"],
                    orderDate = reader["OrderDate"],
                    isSeen = reader["IsNew"],
                    status = reader["OrderStatus"]?.ToString()


                });
            }

            return Ok(list);
        }

        // POST: api/online-orders/markseen
        [HttpPost("markseen")]
        public IActionResult MarkSeen()
        {
            using var con = new MySqlConnection(
                _config.GetConnectionString("MySqlConnection"));
            con.Open();

            string query = "UPDATE orders SET IsNew = 0 WHERE IsNew = 1";
            using var cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            return Ok(new { status = "marked" });
        }



        [HttpPost("update-status")]
        public IActionResult UpdateStatus([FromBody] OrderStatusDto dto)
        {
            using var con = new MySqlConnection(
                _config.GetConnectionString("MySqlConnection"));
            con.Open();

            var cmd = new MySqlCommand(
                "UPDATE orders SET OrderStatus=@status WHERE OrderID=@id", con);

            cmd.Parameters.AddWithValue("@status", dto.Status);
            cmd.Parameters.AddWithValue("@id", dto.OrderId);

            cmd.ExecuteNonQuery();
            return Ok();
        }


        public class OrderStatusDto
        {
            public int OrderId { get; set; }
            public string Status { get; set; }
        }


    }
}