using Microsoft.EntityFrameworkCore;
using JobTracker.Data;
using JobTracker.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Register DbContext with SQL
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Register Service layer
builder.Services.AddScoped<IJobService, JobService>();

var app=builder.Build();

app.UseHttpsRedirection();
app.UseAuthentication();
app.MapControllers();

app.Run();