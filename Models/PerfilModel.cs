namespace Pontual.Models
{
    public class PerfilModel
    {
        public int IdPerfil { get; private set; }
        public string Nome { get; private set; }
        public string NomeSocial { get; private set; }
        public string Cargo { get; private set; }
        public GraficoModel DadosGrafico { get; private set; }
    }
}