global using BlazorEcommerceNEW.Shared;
global using Microsoft.EntityFrameworkCore;
global using BlazorEcommerceNEW.Data;
global using BlazorEcommerceNEW.Services.ProductService;
global using BlazorEcommerceNEW.Services.CategoryService;
global using BlazorEcommerceNEW.Services.CartService;
using BlazorEcommerceNEW.Client.Pages;
using BlazorEcommerceNEW.Components;
using BlazorEcommerceNEW.Client.Services.ProductService;
using BlazorEcommerceNEW.Client.Services.CartService;
using BlazorEcommerceNEW.Services.AuthService;
using Blazored.LocalStorage;
using BlazorEcommerceNEW.Services.CartService;
using BlazorEcommerceNEW.Client.Services.AuthService;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// F�ge hier die Controller-Dienste hinzu, um API-Endpunkte zu unterst�tzen
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7137/")
});

builder.Services.AddScoped<IServerProductService, ServerProductService>();
builder.Services.AddScoped<IServerCartService, ServerCartService>();
builder.Services.AddScoped<IServerAuthService, ServerAuthService>();

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IServerCategoryService, ServerCategoryService>();

builder.Services.AddDbContext<DataContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
} );
builder.Services.AddControllers(); // Diese Zeile f�gt die Unterst�tzung f�r API-Controller hinzu

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


app.UseSwaggerUI();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseSwagger();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

// F�ge hier die Routen f�r die API-Controller hinzu
app.MapControllers(); // Diese Zeile stellt sicher, dass die API-Routen korrekt funktionieren

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorEcommerceNEW.Client._Imports).Assembly);

app.Run();
