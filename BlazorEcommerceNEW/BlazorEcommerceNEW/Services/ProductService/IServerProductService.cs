namespace BlazorEcommerceNEW.Services.ProductService
{
    public interface IServerProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
    }
}
