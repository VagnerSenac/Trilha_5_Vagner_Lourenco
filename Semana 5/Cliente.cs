namespace Comex
{
    public class Cliente
    {
        public string Nome { get; set; } 
        public string CPF { get; set; }
        public string email { get; set; } 
        public string Profissao { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}
