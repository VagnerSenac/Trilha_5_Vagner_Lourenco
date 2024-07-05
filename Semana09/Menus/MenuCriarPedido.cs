using Comex.Modelos.Cliente;
using Comex.Modelos.Produtos;
using Comex.Uteis;

namespace Comex.Menus
{
    public class MenuCriarPedido
    {

        public void CriarPedido(List<Produto> listaDeProdutos, List<Pedido> listaPedidos)
        {

            Console.Clear();
            Console.WriteLine("Criando um novo Pedido \n");
            Console.WriteLine("Digite o nome do Cliente: ");
            string nomeCliente = Console.ReadLine();
            var cliente = new Cliente();
            cliente.nome = nomeCliente;

            var pedido = new Pedido(cliente);

            Console.WriteLine("\nProdutos Disponíveis: ");
            for (int i = 0; i < listaDeProdutos.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {listaDeProdutos[i].Nome}");
            }
            Console.WriteLine("Digite o número do produto que deseja adicionar: ");
            int numeroProduto = int.Parse(Console.ReadLine());
            var produto = listaDeProdutos[numeroProduto - 1];

            Console.WriteLine("Digite a quanidade desejada: ");
            var quantidade = int.Parse(Console.ReadLine());

            var itemdePedido = new ItemPedido(produto, quantidade);
            pedido.AdicionarItem(itemdePedido);
            Console.WriteLine($"Item adicionado com Sucesso!\n");
            listaPedidos.Add(pedido);
            Console.WriteLine($"Pedido criado com Sucesso!\n");
            VoltarMenu.VoltarAoMenu();


        }
    }
}
