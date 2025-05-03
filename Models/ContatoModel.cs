using Pontual.Enum;

namespace Pontual.Models
{
    public class ContatoModel
    {
        public int IdContato { get; private set; }
        public ETipoContato TipoContato { get; private set; }
        public string Contato { get; private set; } = string.Empty;
        public bool FlagWhatsApp { get; private set; } = true;
    }
}