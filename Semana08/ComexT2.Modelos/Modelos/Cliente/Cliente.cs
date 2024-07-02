using Comex.Modelos.Interfaces;

namespace Comex.Modelos.Cliente
{
    public class Cliente : IIidentificavel
    {
        /// <summary>
        /// Dados de cadastro de Cliente
        /// </summary>
        public string nome { get; set; }
        public string CPF { get; set; }
        public string email { get; set; }
        public string Profissao { get; set; }
        public string Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public string Identificavel()
        {
            return $"Cliente : {nome}, CPF:{CPF}";
        }
    }
}
