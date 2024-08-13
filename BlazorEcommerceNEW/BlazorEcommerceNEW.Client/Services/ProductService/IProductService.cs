using BlazorEcommerceNEW.Shared;

namespace BlazorEcommerceNEW.Client.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
