namespace Comex.Modelos.Cliente
{
    /// <summary>
    /// Caladstro base do endereço do cliente
    /// </summary>
    public class Endereco
    {
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
    }
}
