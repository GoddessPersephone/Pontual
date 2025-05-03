namespace Pontual.DTO.Post
{
    public class LoginPostDTO
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string ContraSenha { get; set; }
        public bool FlagLoginAutomatico { get; set; } = false;
    }
}