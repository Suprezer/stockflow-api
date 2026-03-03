using Microsoft.AspNetCore.Mvc;

namespace stockflow_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(new[] { "Product1", "Product2", "Product3" });
        }

        [HttpGet]
        public IActionResult GetProduct(int id) {
            return Ok($"Product{id}");
        }
    }
}
