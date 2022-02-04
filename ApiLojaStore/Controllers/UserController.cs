using ApiLojaStore.Context;
using ApiLojaStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiLojaStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly BDContext _context;
        public UserController(BDContext context)
        {
            _context = context;

        }
        [HttpGet("Index")]
        public async Task<IActionResult> Index()
        {
            var users = await _context.Users.ToListAsync();
            if (users is null)
            {
                return NotFound();
            }

            return Ok(users);
        }
        [HttpGet("view")]
        public async Task<IActionResult> View(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([Bind("Name, Email, Password")] User user)
        {
            _context.Add(user);
            await _context.SaveChangesAsync();


            return Ok(user);
        }
        [HttpPatch("Update")]
        public async Task<IActionResult> Update(int id, [Bind("Name, Email, Password")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }


            try
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
                return Ok(user);

            }
            catch (DbUpdateConcurrencyException)
            {

            }
            return NotFound();

        }
        [HttpDelete("Delete")]

        public async Task<IActionResult> Delete(int? id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return Ok("Usuario excluída com sucesso");

        }
    }
}
