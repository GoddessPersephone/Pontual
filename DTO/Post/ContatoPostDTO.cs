using Pontual.Enum;

namespace Pontual.DTO.Post
{
    public class ContatoPostDTO
    {
        public ETipoContato TipoContato { get; set; }
        public string Contato { get; set; } = string.Empty;
        public bool FlagWhatsApp { get; set; } = true;
    }
}