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

        [HttpPost]
        public IActionResult CreateProduct([FromBody] CreateProductRequest request)
        {
            return CreatedAtAction(nameof(GetProduct), new { id = 1 }, "ProductCreated");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] UpdateProductRequest request)
        {
            return Ok($"Product{id} updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return NoContent();
        }
    }
}
