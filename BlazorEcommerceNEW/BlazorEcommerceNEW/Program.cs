global using BlazorEcommerceNEW.Shared;
global using Microsoft.EntityFrameworkCore;
global using BlazorEcommerceNEW.Data;
global using BlazorEcommerceNEW.Services.ProductService;
using BlazorEcommerceNEW.Client.Pages;
using BlazorEcommerceNEW.Components;
using BlazorEcommerceNEW.Client.Services.ProductService;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Füge hier die Controller-Dienste hinzu, um API-Endpunkte zu unterstützen
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7137/")
});
builder.Services.AddScoped<IServerProductService, ServerProductService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDbContext<DataContext>(options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
} );
builder.Services.AddControllers(); // Diese Zeile fügt die Unterstützung für API-Controller hinzu

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

// Füge hier die Routen für die API-Controller hinzu
app.MapControllers(); // Diese Zeile stellt sicher, dass die API-Routen korrekt funktionieren

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorEcommerceNEW.Client._Imports).Assembly);

app.Run();
