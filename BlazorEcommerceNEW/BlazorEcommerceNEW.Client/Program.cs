global using BlazorEcommerceNEW.Shared;
global using System.Net.Http.Json;
global using BlazorEcommerceNEW.Client.Services.ProductService;
global using BlazorEcommerceNEW.Client.Services.CategoryServices;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
await builder.Build().RunAsync();
