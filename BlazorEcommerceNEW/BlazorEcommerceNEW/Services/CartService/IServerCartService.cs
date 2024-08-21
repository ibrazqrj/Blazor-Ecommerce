namespace BlazorEcommerceNEW.Services.CartService
{
    public interface IServerCartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartItem> cartItems);
    }
}
