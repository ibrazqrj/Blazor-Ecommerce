global using BlazorEcommerceNEW.Shared;
global using System.Net.Http.Json;
global using BlazorEcommerceNEW.Client.Services.ProductService;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
await builder.Build().RunAsync();
