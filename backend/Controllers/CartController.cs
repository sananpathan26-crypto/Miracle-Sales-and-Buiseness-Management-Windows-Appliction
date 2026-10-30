using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/cart")]
    public class CartController : ControllerBase
    {
        private readonly IConfiguration _config;

        public CartController(IConfiguration config)
        {
            _config = config;
        }

        // ✅ ADD TO CART
        [HttpPost("add")]
        public IActionResult AddToCart([FromBody] AddCartDto item)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return Unauthorized("Login required");

            string connStr = _config.GetConnectionString("MySqlConnection");


            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string checkQuery = "SELECT id, quantity FROM carts WHERE user_id=@uid AND product_id=@pid";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@uid", userId);
                checkCmd.Parameters.AddWithValue("@pid", item.ProductId);

                using (var reader = checkCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int cartId = reader.GetInt32("id");
                        int qty = reader.GetInt32("quantity") + 1;
                        reader.Close();

                        string updateQuery = "UPDATE carts SET quantity=@qty WHERE id=@id";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@qty", qty);
                        updateCmd.Parameters.AddWithValue("@id", cartId);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        reader.Close();

                        string insertQuery = @"INSERT INTO carts
                            (user_id, product_id, product_name, price, image_url, quantity)
                            VALUES (@uid,@pid,@name,@price,@img,1)";

                        MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@uid", userId);
                        insertCmd.Parameters.AddWithValue("@pid", item.ProductId);
                        insertCmd.Parameters.AddWithValue("@name", item.ProductName);
                        insertCmd.Parameters.AddWithValue("@price", item.Price);
                        insertCmd.Parameters.AddWithValue("@img", item.ImageUrl);
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }

            return Ok(new { message = "Added to cart" });
        }

        // ✅ GET CART
        [HttpGet("mycart")]
        public IActionResult GetMyCart()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return Unauthorized();

            string connStr = _config.GetConnectionString("MySqlConnection");

            List<object> cartItems = new List<object>();

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM carts WHERE user_id=@uid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@uid", userId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cartItems.Add(new
                        {
                            Id = reader["id"],
                            ProductId = reader["product_id"],
                            Name = reader["product_name"],
                            Price = reader["price"],
                            Image = reader["image_url"],
                            Quantity = reader["quantity"]
                        });
                    }
                }
            }

            return Ok(cartItems);
        }


        [HttpPost("update")]
        public IActionResult UpdateQuantity([FromBody] updateCartDto model)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return Unauthorized();

            string connStr = _config.GetConnectionString("MySqlConnection");

            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string selectQuery = "SELECT quantity FROM carts WHERE user_id=@uid AND product_id=@pid";
                MySqlCommand selectCmd = new MySqlCommand(selectQuery, conn);
                selectCmd.Parameters.AddWithValue("@uid", userId);
                selectCmd.Parameters.AddWithValue("@pid", model.ProductId);

                var result = selectCmd.ExecuteScalar();

                if (result == null)
                    return NotFound();

                int currentQty = Convert.ToInt32(result);
                int newQty = currentQty + model.Change;

                if (newQty <= 0)
                {
                    string deleteQuery = "DELETE FROM carts WHERE user_id=@uid AND product_id=@pid";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@uid", userId);
                    deleteCmd.Parameters.AddWithValue("@pid", model.ProductId);
                    deleteCmd.ExecuteNonQuery();
                }
                else
                {
                    string updateQuery = "UPDATE carts SET quantity=@qty WHERE user_id=@uid AND product_id=@pid";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@qty", newQty);
                    updateCmd.Parameters.AddWithValue("@uid", userId);
                    updateCmd.Parameters.AddWithValue("@pid", model.ProductId);
                    updateCmd.ExecuteNonQuery();
                }
            }

            return Ok();
        }

    }
}
