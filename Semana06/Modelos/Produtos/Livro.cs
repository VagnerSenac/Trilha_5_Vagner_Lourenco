using Comex.Modelos.Interfaces;

namespace Comex.Modelos.Produtos
{
    internal class Livro : Produto,IIidentificavel
    {
        public Livro(string nome) : base(nome)
        {
        }

        public string Isbn { get; set; }
        public int TotaldePaginas { get; set; }

        public string Identificavel()
        {
            return $"Livro : {Nome}, ISBN:{Isbn}";
        }
    }
}
