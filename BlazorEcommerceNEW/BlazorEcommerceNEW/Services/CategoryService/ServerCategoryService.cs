
namespace BlazorEcommerceNEW.Services.CategoryService
{
    public class ServerCategoryService : IServerCategoryService
    {
        private readonly DataContext _context;

        public ServerCategoryService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }

        public Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
