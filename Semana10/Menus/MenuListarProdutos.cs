using Comex.Modelos.Produtos;
using Comex.Data;
using Comex.Uteis;

namespace Comex.Menus
{
    public class MenuListarProdutos
    {
        public void ListarProdutos(ProdutoRespository produtoRepository)
        {
            // Código da Consulta produos já cadastrados
            Console.Clear();
            var listaDeProdutos = produtoRepository.Listar().ToList();
            Console.WriteLine("Lista de Produto");

            foreach (var produto in listaDeProdutos)
            {
                Console.WriteLine($"Produto: {produto.Nome}, " + $"Descrição: {produto.PrecoProdutos}, " + $"Preço: {produto.PrecoProdutos}, " + $"Quantidade: {produto.Quantidade}, ");
            }

            VoltarMenu.VoltarAoMenu();
        }



    }
}
