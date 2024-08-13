using BlazorEcommerceNEW.Client.Services.ProductService;

namespace BlazorEcommerceNEW.Services.ProductService
{
    public class ServerProductService : IProductService
    {
        private readonly DataContext _context;
        public ServerProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _context.Products.ToListAsync()
            };

            return response;
        }
    }
}
