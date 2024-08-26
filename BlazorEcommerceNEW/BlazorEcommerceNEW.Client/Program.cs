global using BlazorEcommerceNEW.Shared;
global using System.Net.Http.Json;
global using BlazorEcommerceNEW.Client.Services.ProductService;
global using BlazorEcommerceNEW.Client.Services.CategoryServices;
global using BlazorEcommerceNEW.Client.Services.AuthService;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using BlazorEcommerceNEW.Client.Services.CartService;
using BlazorEcommerceNEW.Client.Services.AuthService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();

await builder.Build().RunAsync();
