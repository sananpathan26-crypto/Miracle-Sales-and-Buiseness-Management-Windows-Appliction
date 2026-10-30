using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/highsell")]
    public class HighSellController : ControllerBase
    {

         private readonly string _connectionString;

        public HighSellController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MySqlConnection");
        }

        // 🔥 ADMIN: Top 5 Highly Selling Products
        // GET: /api/highsell/top-5-products
        [HttpGet("top-5-products")]
        public IActionResult GetTop5HighlySellingProducts()
        {
            var products = new List<object>();

            using (var con = new MySqlConnection(_connectionString))
            {
                con.Open();

                string query = @"
                    SELECT 
                        ProductName,
                        SUM(Quantity) AS TotalSold,
                        SUM(Quantity * Price) AS TotalRevenue
                    FROM orders
                    WHERE OrderStatus = 'Delivered'
                    GROUP BY ProductName
                    ORDER BY TotalSold DESC
                    LIMIT 5";

                using (var cmd = new MySqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new
                        {
                            productName = reader["ProductName"].ToString(),
                            totalSold = reader.GetInt32("TotalSold"),
                            totalRevenue = reader.GetDecimal("TotalRevenue")
                        });
                    }
                }
            }

            return Ok(products);
        }
    }
}








