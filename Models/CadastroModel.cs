namespace Pontual.Models
{
    public class CadastroModel
    {
        public int IdCadastro { get; private set; }
        public LoginModel DadosLogin { get; private set; }
        public PerfilModel DadosPerfil { get; private set; }
        public RegistroPontoModel DadosRegistroPonto { get; private set; }
        public List<ContatoModel> DadosContato { get; private set; }
        public List<EnderecoModel> DadosEndereco { get; private set; }
        public string Documento { get; private set; }
        public bool FlagAtivo { get; private set; } = true;
        public DateTime DataNiver { get; private set; }
        public DateTime DataCadastro { get; private set; } = DateTime.Now;
        public UsuarioModel DadosUsuario { get; private set; }
    }
}