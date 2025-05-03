namespace Pontual.Models
{
    public class GraficoModel
    {
        public int IdGrafico { get; private set; }
        public decimal Ausencia { get; private set; }//Dias Off
        public decimal Intevalo { get; private set; }//Pausas 
        public decimal Jornada { get; private set; }//Percorrido
        public decimal CargaHoraria { get; private set; }//A percorrer
        public decimal Descanso { get; private set; }//Tempo Livre Obrigatorio
        public decimal BancoTotal { get; private set; }
        public bool FlagFerias { get; private set; } = false;
        public decimal? Ferias { get; private set; }
    }
}