var builder = WebApplication.CreateBuilder(args);

// Add controller support
builder.Services.AddControllers();

var app = builder.Build();

// app.UseHttpsRedirection();

// Enable controllers
app.MapControllers();

app.Run();