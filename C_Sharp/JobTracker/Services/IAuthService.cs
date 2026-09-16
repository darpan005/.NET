using JobTracker.Dtos;
using JobTracker.DTOs;

namespace JobTracker.Services
{
    public interface IAuthService
    {
        Task<string?> RegistrAsync(RegisterDto dto);
        Task<string> LoginAsync(LoginDto dto);
    }
}