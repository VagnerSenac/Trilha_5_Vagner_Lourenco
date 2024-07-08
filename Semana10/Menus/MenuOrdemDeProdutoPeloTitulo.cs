using Comex.Modelos.Produtos;
using Comex.Uteis;

namespace Comex.Menus
{
    public class MenuOrdemDeProdutoPeloTitulo
    {
        public void OrdemDeProdutoPeloTitulo(List<Produto> listaDeProdutos)
        {
            var produtosOrdenados = listaDeProdutos.OrderBy(p => p.Nome).ToList();
            Console.Clear();
            Console.WriteLine("Produtos ordenados pelo título:");
            for (int i = 0; i < produtosOrdenados.Count; i++)
            {
                Console.WriteLine($"Produto: {produtosOrdenados[i].Nome}, Preço: {produtosOrdenados[i].PrecoProdutos:F2}");
            }
            VoltarMenu.VoltarAoMenu();

        }
    }
}
