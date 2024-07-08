using Comex.Modelos.Cliente;
using Comex.Modelos.Produtos;
using Comex.Uteis;

namespace Comex.Menus
{
    public class MenuListarPedidos
    {

        public void ListarPedidos(List<Produto> listaDeProdutos, List<Pedido> listaPedidos)
        {
            Console.Clear();
            Console.WriteLine("Listando Todos os pedidos criados \n");

            var pedidosOrdenados = listaPedidos.OrderBy(p => p.Cliente.nome).ToList();

            foreach (var pedido in pedidosOrdenados)

            {
                Console.WriteLine($"Pedido {pedido}");
            }

            VoltarMenu.VoltarAoMenu();

        }
    }
}
