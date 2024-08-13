using BlazorEcommerceNEW.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerceNEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(DataContext context)
        {
            Context = context;
        }

        public DataContext Context { get; }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var products = await Context.Products.ToListAsync();
            return Ok(products);
        }
    }
}
