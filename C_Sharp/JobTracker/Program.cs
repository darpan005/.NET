using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using JobTracker.Data;
using JobTracker.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Register DbContext with SQL
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Register Service layer
builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddScoped<IAuthService,AuthService>();

var key = Encoding.UTF8.GetBytes(builder.Configuration["Jwt:key"]!);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
     options.TokenValidationParameters = new TokenValidationParameters
     {
                                        ValidateIssuerSigningKey=true,
                                        IssuerSigningKey= new SymmetricSecurityKey(key),
                                        ValidateIssuer=true,
                                        ValidIssuer=builder.Configuration["Jwt:Issuer"],
                                        ValidateAudience=true,
                                        ValidAudience= builder.Configuration["Jwt:Audience"],
                                        ValidateLifetime=true         
     };
});


var app=builder.Build();

app.UseHttpsRedirection();


app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();