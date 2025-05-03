using Pontual.Enum;

namespace Pontual.Models
{
    public class RegistroPontoModel
    {
        public int IdRegistroPonto { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataRegistro { get; set; }
        public ETipoRegistroPonto TipoRegistroPonto { get; set; }
    }
}