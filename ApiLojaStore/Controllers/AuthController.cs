using ApiLojaStore.Context;
using Microsoft.AspNetCore.Mvc;


namespace ApiLojaStore.Controllers
{ 


    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly BDContext _context;
        public AuthController(BDContext context)
        {
            _context = context;

        }
        [HttpPost]
        public async Task<IActionResult> Login(string Email, string Password)
        {
            var user = _context.Users.Where(u => u.Email == Email && u.Password == Password).ToList();
            if (user.Any())
            {
               

                return Ok(user);

            }

            return Ok("Usuario não logado");
        }


    [HttpGet]
    public async Task<IActionResult> Logout()
    {
            return Ok("Deslogado");

        }
    }
}
