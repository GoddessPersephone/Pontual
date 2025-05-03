using Pontual.DTO.Post;

namespace Pontual.DTO.Put
{
    public class PutCadastroDTO
    { 
        public int IdUsuario { get; set; }
        public LoginPostDTO DadosLogin { get; set; }
        public PerfilPostDTO DadosPerfil { get; set; }
        public List<ContatoPostDTO> DadosContato { get; set; }
        public List<EnderecoPostDTO> DadosEndereco { get; set; }
        public string Documento { get; set; }
        public bool FlagAtivo { get; set; } = true;
        public DateTime DataNiver { get; set; }
    }
}