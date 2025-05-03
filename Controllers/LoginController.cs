using Microsoft.AspNetCore.Mvc;
using Pontual.DTO.Get;

namespace Pontual.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // Exibe tela de login
        }

        [HttpPost]
        public IActionResult Index(LoginDTO login)
        {
            // Simples validação (substitua por autenticação real)
            bool usuarioExiste = false; // simule a verificação

            if (!usuarioExiste)
            {
                TempData["PrimeiroAcesso"] = true;
                return RedirectToAction("Index", "Cadastro");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
