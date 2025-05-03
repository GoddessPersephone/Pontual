namespace Pontual.Models
{
    public class EnderecoModel
    {
        public int IdEndereco { get; private set; }
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Referencia { get; private set; }
        public string CEP { get; private set; }
        public string UF { get; private set; }
        public string Pais { get; private set; }
    }
}