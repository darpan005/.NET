using JobTracker.Dtos;
using JobTracker.DTOs;

namespace JobTracker.Services
{
    public interface IAuthService
    {
        Task<string?> RegisterAsync(RegisterDto dto);
        Task<string> LoginAsync(LoginDto dto);
    }
}