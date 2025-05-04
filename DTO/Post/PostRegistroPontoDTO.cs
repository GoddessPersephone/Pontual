using Pontual.Enum;

namespace Pontual.DTO.Post
{
    public class PostRegistroPontoDTO
    {
        public int IdUsuario { get; set; }//usuario do cadastro que logou no sistema
        public DateTime DataRegistro { get; set; }
        public ETipoRegistroPonto TipoRegistroPonto { get; set; }
    }
}