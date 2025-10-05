using Microsoft.EntityFrameworkCore;
using BlazorPostgres.Components;
using BlazorPostgres.Data;
using BlazorPostgres.Interfaces;
using BlazorPostgres.Repositories;  

var builder = WebApplication.CreateBuilder(args);


// 1. Obter a string de conexão
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// 2. Configurar o DbContext para usar PostgreSQL (Npgsql)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));


builder.Services.AddScoped<ICategoriasRepositories, CategoriasRepositories>();
builder.Services.AddScoped<IProdutosRepositories, ProdutosRepositories>();



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
