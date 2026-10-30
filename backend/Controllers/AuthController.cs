using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace backend.Controllers
    {
        [ApiController]
        [Route("api/auth")]
        public class AuthController : ControllerBase
        {
            [HttpGet("set-user")]
            public IActionResult SetUser([FromQuery] int userId)
            {
                if (userId <= 0)
                    return BadRequest("Invalid user");

                // save userId in session
                HttpContext.Session.SetInt32("UserId", userId);

                // redirect to index.html
                return Redirect("/");
            }

            [HttpGet("me")]
            public IActionResult Me()
            {
                var userId = HttpContext.Session.GetInt32("UserId");

                if (userId == null)
                    return Unauthorized();

                return Ok(new { userId });
            }

            [HttpPost("logout")]
            public IActionResult Logout()
            {
                HttpContext.Session.Clear();
                return Ok();
            }
        }
    }

}
