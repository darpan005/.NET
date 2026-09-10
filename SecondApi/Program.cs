using SecondApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add Controller support 
builder.Services.AddControllers();

//Register Services 
builder.Services.AddScoped<ProductService>();

var app = builder.Build();

// Map controllers 
app.MapControllers();

app.Run();