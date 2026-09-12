using Day6.Repositories;
using Day6.Service;

var builder = WebApplication.CreateBuilder();

builder.Services.AddControllers();

//Register 
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

app.MapControllers();

app.Run();