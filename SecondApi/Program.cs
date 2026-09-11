using SecondApi.Services;
using SecondApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add Controller support 
builder.Services.AddControllers();

//Register Services 
builder.Services.AddScoped<IProductService, ProductService>();

// Register Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Map controllers 
app.MapControllers();

app.Run();