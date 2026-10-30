using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IConfiguration _config;

        public OrdersController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet("dbcheck")]
        public IActionResult Check()
        {
            try
            {
                using var con = new MySqlConnection(
                    _config.GetConnectionString("MySqlConnection"));

                con.Open();

                return Ok(new { db = "connected" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    db = "failed",
                    error = ex.Message
                });
            }
        }

        [HttpPost("place")]
        public IActionResult PlaceOrder([FromBody] OrderDto order)
        {
            try
            {
                using var con = new MySqlConnection(
                    _config.GetConnectionString("MySqlConnection"));

                con.Open();

                string query = @"INSERT INTO orders
                    (CustomerName, Mobile, Email, Address, ProductName, Price, OrderDate, PaymentMode)
                    VALUES
                    (@name, @mobile, @email, @address, @product, @price, NOW(), @mode)";

                using var cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", order.CustomerName);
                cmd.Parameters.AddWithValue("@mobile", order.Mobile);
                cmd.Parameters.AddWithValue("@email", order.Email);
                cmd.Parameters.AddWithValue("@address", order.Address);
                cmd.Parameters.AddWithValue("@product", order.ProductName);
                cmd.Parameters.AddWithValue("@price", order.Price);
                cmd.Parameters.AddWithValue("@mode", order.PaymentMode);

                cmd.ExecuteNonQuery();
                return Ok(new { status = "success" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
