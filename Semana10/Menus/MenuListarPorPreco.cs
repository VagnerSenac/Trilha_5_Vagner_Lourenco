using Comex.Modelos.Produtos;
using Comex.Uteis;

namespace Comex.Menus
{
    public class MenuListarPorPreco
    {

        public void listarPorPreco(List<Produto> listaDeProdutos)
        {
            var produtosOrdenadosPorPreco = listaDeProdutos.OrderBy(p => p.PrecoProdutos).ToList();
            Console.Clear();
            Console.WriteLine("Produtos ordenados pelo preço:");

            for (int i = 0; i < produtosOrdenadosPorPreco.Count; i++)
            {
                Console.WriteLine($"Produto: {produtosOrdenadosPorPreco[i].Nome}, Preço: {produtosOrdenadosPorPreco[i].PrecoProdutos:F2}");
            }
            VoltarMenu.VoltarAoMenu();

        }
    }
}
