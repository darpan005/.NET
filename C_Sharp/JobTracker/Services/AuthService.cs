using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using JobTracker.DTOs;
using JobTracker.Data;
using JobTracker.Models;
using JobTracker.Dtos;

namespace JobTracker.Services
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthService(AppDbContext context, IConfiguration configuration)
        {
            _configuration=configuration;
            _context=context;
        }

        public async Task<string?> RegisterAsync(RegisterDto dto)
        {
            var exitingUser = await _context.Users.FirstOrDefaultAsync(u => u.Email == dto.Email);
            if(exitingUser != null)
            {
                return null;
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password);

            var user = new User
            {
                Email=dto.Email,
                PasswordHash=dto.Password,
                Role= dto.Role
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return "User Registration Successfully";
        }
    }
}