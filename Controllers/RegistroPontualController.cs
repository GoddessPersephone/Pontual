using Microsoft.AspNetCore.Mvc;
using Pontual.DTO.Post;
using Pontual.Models;

namespace Pontual.Controllers
{
    public class RegistroPontualController : Controller
    {
        public IActionResult RegistrarPonto()
        {
            return View();
        }

        // POST: RegistroPonto/Registrar
        [HttpPost]
        public IActionResult Registrar(PostRegistroPontoDTO dto)
        {
            if (!ModelState.IsValid)
            {
                // Se os dados forem inválidos, retorna para a view com os dados preenchidos
                return View("RegistrarPonto", dto);
            }

            var novoRegistro = new RegistroPontoModel
            {
                IdUsuario = dto.IdUsuario,
                DataRegistro = dto.DataRegistro,
                TipoRegistroPonto = dto.TipoRegistroPonto
            };

            // Simulação de gravação (ex: salvar no banco)
            // _context.RegistroPontos.Add(novoRegistro);
            // _context.SaveChanges();

            TempData["Sucesso"] = "Registro de ponto realizado com sucesso!";
            return RedirectToAction("Index","Home");
        }
    }
}
