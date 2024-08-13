
using System.Net.Http.Json;

namespace BlazorEcommerceNEW.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product");
            var products = new List<Product>();
            if (result != null && result.Data != null)
                products = result.Data;

            return new ServiceResponse<List<Product>>
            {
                Data = products
            };
        }
    }
}
