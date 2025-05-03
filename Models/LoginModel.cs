namespace Pontual.Models
{
    public class LoginModel
    {
        public int IdLogin { get; private set; }
        public string Usuario { get; private set; }
        public string Senha { get; private set; }
        public string ContraSenha { get; private set; }
        public bool FlagLoginAutomatico { get; private set; } = false;
    }
}