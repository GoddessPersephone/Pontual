namespace Pontual.Models
{
    public class UsuarioModel
    {
        public int IdUsuario { get; private set; }
        public int IdCadastro { get; private set; }
        public int IdLogin { get; private set; }
        public int IdPerfil { get; private set; }
        public int IdRegistroPonto { get; set; }
        public List<int> ContatoId { get; private set; }
        public List<int> EnderecoId { get; private set; }
    }
}