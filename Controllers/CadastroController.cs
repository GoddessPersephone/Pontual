using Microsoft.AspNetCore.Mvc;
using Pontual.DTO.Post;

namespace Pontual.Controllers
{
    public class CadastroController : Controller
    {
     
        [HttpGet]
        public IActionResult Index()
        {
            var model = new CadastroPostDTO
            {
                DadosUsuario = new UsuarioPostDTO
                {
                    DadosEndereco = new List<EnderecoPostDTO>(),
                    DadosContato = new List<ContatoPostDTO>(),
                    DadosLogin = new LoginPostDTO(),
                    DadosPerfil = new PerfilPostDTO(),
                    Documento = string.Empty,
                    FlagAtivo = true,
                    DataNiver = DateTime.Today
                }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Cadastro(UsuarioPostDTO dados)
        {
            //if (!ModelState.IsValid)
            //    return View(dados);

            // Salvar dados em tabelas de: login, perfil, contatos, endereços, etc.
            // Exemplo fictício:
            // _context.Usuarios.Add(new Usuario { ... });

            TempData["Mensagem"] = "Cadastro realizado com sucesso!";
            return RedirectToAction("RegistrarPonto", "RegistroPontual");
        }
    }
}
