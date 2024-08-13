namespace BlazorEcommerceNEW.Services.CategoryService
{
    public interface IServerCategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
