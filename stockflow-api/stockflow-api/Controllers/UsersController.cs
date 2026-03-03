using Microsoft.AspNetCore.Mvc;

namespace stockflow_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            // Placeholder for fetching all users
            return Ok(new[] { "User1", "User2", "User3" });
        }
    }
}
