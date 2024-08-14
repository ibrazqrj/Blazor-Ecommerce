namespace BlazorEcommerceNEW.Services.CategoryService
{
    public interface IServerCategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
        Task<ServiceResponse<Product>> GetProduct(int productId);

    }
}
