using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoleAuthDemo.Data;
using RoleAuthDemo.Models;

namespace RoleAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        // 1. Public route: Koi bhi access kar sakta hai
        [HttpGet("public")]
        public IActionResult GetPublic()
        {
            return Ok("Public endpoint: Anyone can see this.");
        }

        // 2. Normal User + Admin route: Dono access kar sakte hain
        [Authorize(Roles = "User,Admin")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items);
        }

        // 3. Strict Admin-only route: User role ko 403 Forbidden aayega
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Item item)
        {
            await _context.Items.AddAsync(item);
            await _context.SaveChangesAsync();
            return Ok(item);
        }

        // 4. Strict Admin-only route: Delete operation
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Items.FindAsync(id);
            if (item == null) return NotFound();

            _context.Items.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}