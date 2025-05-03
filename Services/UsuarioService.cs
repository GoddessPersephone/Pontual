using Pontual.DTO.Get;
using Pontual.Interface.IRepositorio;
using Pontual.Interface.IServices;
using Pontual.Models;

namespace Pontual.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _iUsuarioRepositorio;
        public UsuarioService(IUsuarioRepositorio iUsuarioRepositorio)
        {
            _iUsuarioRepositorio = iUsuarioRepositorio;

        }
    }
}