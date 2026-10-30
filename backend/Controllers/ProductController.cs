using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // 🔹 GET ALL PRODUCTS (User Panel)
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products
                .OrderByDescending(p => p.CreatedAt)
                .ToListAsync();

            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            product.CreatedAt = DateTime.Now;

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

    }


}

