using ComexApiT2.Models;
using System.ComponentModel.DataAnnotations;

namespace ComexApiT2.Dtos
{
    public class ReadClienteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Profissao { get; set; }
        public string Telefone { get; set; }
        public ReadEnderecoDto Endereco { get; set; }
    }
}
