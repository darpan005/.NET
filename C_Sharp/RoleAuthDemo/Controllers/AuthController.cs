using Microsoft.AspNetCore.Mvc;
using RoleAuthDemo.DTOs;
using RoleAuthDemo.Services;

namespace RoleAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _auth;

        public AuthController(IAuthService auth)
        {
            _auth = auth;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto dto)
        {
            var res = await _auth.RegisterAsync(dto);
            if (res == null) return BadRequest("User already exists.");
            return Ok(new { message = res });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto dto)
        {
            var token = await _auth.LoginAsync(dto);
            if (token == null) return Unauthorized("Invalid credentials.");
            return Ok(new { token });
        }
    }
}