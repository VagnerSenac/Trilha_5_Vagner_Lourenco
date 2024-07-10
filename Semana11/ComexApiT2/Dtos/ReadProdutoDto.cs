using System.ComponentModel.DataAnnotations;

namespace ComexApiT2.Dtos
{
    public class ReadProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
    }
}
