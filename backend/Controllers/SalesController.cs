using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/sales")]
    public class SalesController : ControllerBase
    {
        private readonly IConfiguration _config;

        public SalesController(IConfiguration config)
        {
            _config = config;
        }

        // 🔹 SUMMARY
        [HttpGet("summary")]
        public IActionResult GetSalesSummary()
        {
            using var con = new MySqlConnection(
              _config.GetConnectionString("MySqlConnection"));
            con.Open();

            var cmd = new MySqlCommand(@"
                SELECT
                    COUNT(*) AS TotalOrders,
                    IFNULL(SUM(quantity),0) AS TotalQty,
                    IFNULL(SUM(price * quantity),0) AS TotalSales
                FROM orders
            ", con);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return Ok(new
                {
                    totalOrders = Convert.ToInt32(reader["TotalOrders"]),
                    totalQty = Convert.ToInt32(reader["TotalQty"]),
                    totalSales = Convert.ToDecimal(reader["TotalSales"])
                });
            }

            return Ok(new { totalOrders = 0, totalQty = 0, totalSales = 0 });
        }

        //// 🔹 DAILY SALES
        //[HttpGet("daily")]
        //public IActionResult GetDailySales(DateTime? startDate, DateTime? endDate)
        //{
        //    var list = new List<object>();

        //    using var con = new MySqlConnection(_config.GetConnectionString("MySqlConnection"));
        //    con.Open();

        //    var query = @"
        //SELECT DATE(orderDate) AS orderDay,
        //       COUNT(*) AS orders,
        //       IFNULL(SUM(quantity),0) AS qty,
        //       IFNULL(SUM(price * quantity),0) AS total
        //FROM orders
        //WHERE 1=1 ";

        //    if (startDate.HasValue)
        //        query += " AND DATE(orderDate) >= @startDate";
        //    if (endDate.HasValue)
        //        query += " AND DATE(orderDate) <= @endDate";

        //    query += " GROUP BY DATE(orderDate) ORDER BY orderDay DESC";

        //    var cmd = new MySqlCommand(query, con);
        //    if (startDate.HasValue) cmd.Parameters.AddWithValue("@startDate", startDate.Value);
        //    if (endDate.HasValue) cmd.Parameters.AddWithValue("@endDate", endDate.Value);

        //    using var reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        list.Add(new
        //        {
        //            date = Convert.ToDateTime(reader["orderDay"]).ToString("yyyy-MM-dd"),
        //            orders = Convert.ToInt32(reader["orders"]),
        //            quantity = Convert.ToInt32(reader["qty"]),
        //            total = Convert.ToDecimal(reader["total"])
        //        });
        //    }

        //    return Ok(list);
        //}


        [HttpGet("daily")]
        public IActionResult GetDailySales(string startDate, string endDate)
        {
            DateTime? start = null;
            DateTime? end = null;

            if (!string.IsNullOrEmpty(startDate))
                start = DateTime.Parse(startDate);
            if (!string.IsNullOrEmpty(endDate))
                end = DateTime.Parse(endDate);

            var list = new List<object>();

            using var con = new MySqlConnection(_config.GetConnectionString("MySqlConnection"));
            con.Open();

            var query = @"
        SELECT DATE(orderDate) AS orderDay,
               COUNT(*) AS orders,
               IFNULL(SUM(quantity),0) AS qty,
               IFNULL(SUM(price * quantity),0) AS total
        FROM orders
        WHERE 1=1 ";

            if (start.HasValue)
                query += " AND DATE(orderDate) >= @startDate";
            if (end.HasValue)
                query += " AND DATE(orderDate) <= @endDate";

            query += " GROUP BY DATE(orderDate) ORDER BY orderDay DESC";

            var cmd = new MySqlCommand(query, con);
            if (start.HasValue) cmd.Parameters.AddWithValue("@startDate", start.Value);
            if (end.HasValue) cmd.Parameters.AddWithValue("@endDate", end.Value);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new
                {
                    date = Convert.ToDateTime(reader["orderDay"]).ToString("yyyy-MM-dd"),
                    orders = Convert.ToInt32(reader["orders"]),
                    quantity = Convert.ToInt32(reader["qty"]),
                    total = Convert.ToDecimal(reader["total"])
                });
            }

            return Ok(list);
        }

    }
}
