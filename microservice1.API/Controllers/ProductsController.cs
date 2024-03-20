using microservice1.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace microservice1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<Product> AddProduct()
        {
            var product = new Product() { Name = "kalem" + Guid.NewGuid().ToString().Substring(0,5) };
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

    }
}
