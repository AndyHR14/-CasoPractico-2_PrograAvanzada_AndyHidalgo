using Microsoft.AspNetCore.Mvc;

namespace Caso2.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidarCredenciales(string Username, string Password)
        {
            var usuario = _context.Usuario
                .FirstOrDefault(u => u.Username == Username && u.Password == Password);

            if (usuario != null)
            {
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }
    }
}