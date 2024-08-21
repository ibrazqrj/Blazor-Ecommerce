using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerceNEW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IServerCartService _cartService;

        public CartController(IServerCartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("products")]
        public async Task<ActionResult<ServiceResponse<List<CartProductResponse>>>> GetCartProducts(List<CartItem> cartItems)
        {
            var resutl = await _cartService.GetCartProducts(cartItems);
            return Ok(resutl);
        }
    }
}
