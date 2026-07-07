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

        [HttpGet]
        public IActionResult GetUserById(int id)
        {
            // Placeholder for fetching a user by ID
            return Ok($"User{id}");
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] string user)
        {
            // Placeholder for creating a new user
            return CreatedAtAction(nameof(GetUserById), new { id = 1 }, user);
        }

        [HttpPut]
        public IActionResult UpdateUser(int id, [FromBody] string user)
        {
            // Placeholder for updating a user
            return NoContent();
        }
    }
}
