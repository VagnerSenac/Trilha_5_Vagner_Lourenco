using Comex.Modelos.Produtos;
using Comex.Uteis;

namespace Comex.Menus
{
    public class MenuCriarProduto
    {
        public void CriarProduto(List<Produto> listaDeProdutos)
        {
            //Código do Cadastro de produtos
            Console.Clear();
            Console.WriteLine("Registro de Produto");
            Console.WriteLine("\nDigite o nome do Produto: ");
            string nomeProduto = Console.ReadLine();

            var Produto = new Produto(nomeProduto);

            Console.WriteLine("\nDigite a descrição do Produto: ");
            string descricaoProduto = Console.ReadLine();
            Produto.descricaoProduto = descricaoProduto;

            Console.WriteLine("\nDigite o preço do Produto: ");
            string precoProdutos = Console.ReadLine();
            Produto.precoProdutos = double.Parse(precoProdutos);

            Console.WriteLine("\nDigite a quantidade do Produto: ");
            string quantidadeProduto = Console.ReadLine();
            Produto.Quantidade = int.Parse(quantidadeProduto);

            listaDeProdutos.Add(Produto);
            Console.WriteLine($"O Produto foi Cadastrado");
            VoltarMenu.VoltarAoMenu();

        }



    }
}
