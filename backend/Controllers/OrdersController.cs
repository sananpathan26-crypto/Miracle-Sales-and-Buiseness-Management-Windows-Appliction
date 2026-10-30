using backend.Hubs;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IHubContext<OrderHub> _hub;

        // ✅ FIXED CONSTRUCTOR
        public OrdersController(IConfiguration config, IHubContext<OrderHub> hub)
        {
            _config = config;
            _hub = hub;
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
        public async Task<IActionResult> PlaceOrder([FromBody] OrderDto order)
        {
            try
            {
                using var con = new MySqlConnection(
                    _config.GetConnectionString("MySqlConnection"));
                con.Open();

                int customerId;

                // 1️⃣ Check existing customer
                string checkCustomer =
                    "SELECT CustomerID FROM online_customers WHERE Mobile = @mobile";

                using (var cmdCheck = new MySqlCommand(checkCustomer, con))
                {
                    cmdCheck.Parameters.AddWithValue("@mobile", order.Mobile);
                    var result = cmdCheck.ExecuteScalar();

                    if (result != null)
                    {
                        customerId = Convert.ToInt32(result);
                    }
                    else
                    {
                        // 2️⃣ Insert customer
                        string insertCustomer = @"
                    INSERT INTO online_customers
                    (CustomerName, Mobile, Email, Address)
                    VALUES
                    (@name, @mobile, @email, @address);
                    SELECT LAST_INSERT_ID();";

                        using var cmdInsert = new MySqlCommand(insertCustomer, con);
                        cmdInsert.Parameters.AddWithValue("@name", order.CustomerName);
                        cmdInsert.Parameters.AddWithValue("@mobile", order.Mobile);
                        cmdInsert.Parameters.AddWithValue("@email", order.Email);
                        cmdInsert.Parameters.AddWithValue("@address", order.Address);

                        customerId = Convert.ToInt32(cmdInsert.ExecuteScalar());
                    }
                }


                var userId = HttpContext.Session.GetInt32("UserId");
                if (userId == null)
                    return Unauthorized("Login required");

                // 3️⃣ Insert order
                string insertOrder = @"
            INSERT INTO orders
            (CustomerID, user_id, ProductName, Price, Quantity, OrderDate, PaymentMode, IsNew)
            VALUES
            (@cid, @uid, @product, @price, @qty, NOW(), @mode, 1)";

                using var cmdOrder = new MySqlCommand(insertOrder, con);
                cmdOrder.Parameters.AddWithValue("@cid", customerId);
                cmdOrder.Parameters.AddWithValue("@uid", userId);
                cmdOrder.Parameters.AddWithValue("@product", order.ProductName);
                cmdOrder.Parameters.AddWithValue("@price", order.Price);
                cmdOrder.Parameters.AddWithValue("@qty", order.Quantity);
                cmdOrder.Parameters.AddWithValue("@mode", order.PaymentMode);
                cmdOrder.ExecuteNonQuery();

                // 4️⃣ SignalR notify
                await _hub.Clients.All.SendAsync("NewOrder", new
                {
                    order.CustomerName,
                    order.ProductName,
                    order.Quantity
                });

                return Ok(new { status = "success" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        

       
    }
}
