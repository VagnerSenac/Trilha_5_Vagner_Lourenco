

namespace Comex
{
    public class Produto
    {
        public Produto() { }
        public Produto (string nome)
        {
            Nome = nome;
        }


        public string Nome { get; set; }
        public double precoProdutos { get; set; }
        public string descricaoProduto { get; set; }
        public int Quantidade { get; set; }
    }
}