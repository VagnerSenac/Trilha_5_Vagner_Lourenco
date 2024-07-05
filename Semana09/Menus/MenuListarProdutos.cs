using Comex.Modelos.Produtos;
using Comex.Uteis;

namespace Comex.Menus
{
    public class MenuListarProdutos
    {
        public void ListarProdutos(List<Produto> listaDeProdutos)
        {
            // Código da Consulta produos já cadastrados
            Console.Clear();
            Console.WriteLine("Lista de Produto");

            foreach (var produto in listaDeProdutos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, " + $"Descrição: {produto.precoProdutos}, " + $"Preço: {produto.precoProdutos}, " + $"Quantidade: {produto.Quantidade}, ");
            }

            VoltarMenu.VoltarAoMenu();
        }



    }
}
