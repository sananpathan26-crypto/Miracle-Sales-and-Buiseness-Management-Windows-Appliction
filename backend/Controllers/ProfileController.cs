using backend.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/profile")]
    public class ProfileController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ProfileController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("me")]
        public IActionResult GetProfile()
        {
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return Unauthorized();

            using var con = new MySqlConnection(
                _config.GetConnectionString("MySqlConnection"));

            con.Open();

            var cmd = new MySqlCommand(
                "SELECT username, email FROM signup WHERE user_id=@id", con);

            cmd.Parameters.AddWithValue("@id", userId);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return NotFound();

            return Ok(new
            {
                username = reader.GetString("username"),
                email = reader.GetString("email")
            });
        }

        //[HttpPost("update")]
        //public IActionResult UpdateProfile([FromBody] ProfileUpdateModel dto)
        //{
        //    int? userId = HttpContext.Session.GetInt32("UserId");

        //    Console.WriteLine("USER ID FROM SESSION = " + userId);

        //    if (userId == null)
        //        return Unauthorized("No session user");

        //    if (userId == null)
        //        return Unauthorized("User not logged in");

        //    using var con = new MySqlConnection(
        //        _config.GetConnectionString("MySqlConnection"));
        //    con.Open();

        //    // 1️⃣ Check if email already exists for another user
        //    var checkCmd = new MySqlCommand(
        //        "SELECT COUNT(*) FROM signup WHERE email=@e AND user_id <> @id", con);
        //    checkCmd.Parameters.AddWithValue("@e", dto.Email);
        //    checkCmd.Parameters.AddWithValue("@id", userId);

        //    int emailCount = Convert.ToInt32(checkCmd.ExecuteScalar());
        //    if (emailCount > 0)
        //        return BadRequest("Email already exists");

        //    // 2️⃣ Update profile
        //    var cmd = new MySqlCommand(
        //        @"UPDATE signup 
        //  SET username=@u, email=@e 
        //  WHERE user_id=@id", con);

        //    cmd.Parameters.AddWithValue("@u", dto.Username);
        //    cmd.Parameters.AddWithValue("@e", dto.Email);
        //    cmd.Parameters.AddWithValue("@id", userId);

        //    int rows = cmd.ExecuteNonQuery();

        //    if (rows == 0)
        //        return BadRequest("Update failed");

        //    return Ok("Profile updated successfully");
        //}

        [HttpPost("update")]
        public IActionResult UpdateProfile([FromBody] ProfileUpdateModel dto)
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            Console.WriteLine("UserId = " + userId);

            if (userId == null)
                return Unauthorized("Not logged in");

            using var con = new MySqlConnection(
                _config.GetConnectionString("MySqlConnection"));
            con.Open();

            // Email exists check
            var check = new MySqlCommand(
                "SELECT COUNT(*) FROM signup WHERE email=@e AND user_id!=@id", con);

            check.Parameters.AddWithValue("@e", dto.Email);
            check.Parameters.AddWithValue("@id", userId);

            if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                return BadRequest("Email already exists");

            var cmd = new MySqlCommand(
                "UPDATE signup SET username=@u, email=@e WHERE user_id=@id", con);

            cmd.Parameters.AddWithValue("@u", dto.Username);
            cmd.Parameters.AddWithValue("@e", dto.Email);
            cmd.Parameters.AddWithValue("@id", userId);

            int rows = cmd.ExecuteNonQuery();

            if (rows == 0)
                return BadRequest("Update failed");

            return Ok("Profile updated");
        }




    }
}
