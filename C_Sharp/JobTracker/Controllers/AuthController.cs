using Microsoft.AspNetCore.Mvc;
using JobTracker.DTOs;
using JobTracker.Services;
using JobTracker.Dtos;

namespace JobTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService=authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            var result = await _authService.RegisterAsync(dto);
            if(result == null)
            {
                return BadRequest("Email Already Exist");
            }

            return Ok(new {message = result} );
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var token = await _authService.LoginAsync(dto);
            if(token == null)
            {
                return Unauthorized("Invalid email or password.");
            }

            return Ok(new{token});

        }
    }
}