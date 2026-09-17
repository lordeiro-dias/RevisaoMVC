using ItensMercado.Data;
using Microsoft.AspNetCore.Mvc;

namespace ItensMercado.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

		public LoginController(AppDbContext context)
        {
            _context = context;
		}

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                ViewBag.Erro = "Preencha todos os campos.";
                return View("Index");
            }

            var usuario = _context.Usuarios.FirstOrDefault(u => u.Email == email);

            if (usuario == null)
            {
                ViewBag.Erro = "E-mail ou senha incorretos";
				return View("Index");
            }

            if (usuario.Senha != senha.ToString())
            {
				ViewBag.Erro = "E-mail ou senha incorretos";
				return View("Index");
			}

            HttpContext.Session.SetString("UsuarioNome", usuario.Nome);
            HttpContext.Session.SetInt32("UsuarioId", usuario.UsuarioID);

			return RedirectToAction("Index", "Home");
		}

        public IActionResult Sair()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
