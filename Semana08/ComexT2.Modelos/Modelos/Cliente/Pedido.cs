using Comex.Modelos.Produtos;
using System.Data;

namespace Comex.Modelos.Cliente
{

/// <summary>
/// Represena um pedido realizado por um cliente
/// </summary>


    public class Pedido
    {
        /// <summary>
        /// Inicializa uma nova instancia da classe de Pedido.
        /// </summary>
        /// <param name="cliente"> O cliente realizou o pedido</param>
        public Pedido(Cliente cliente)
        {
            Cliente = cliente;
            Data = DateTime.Now;
            Itens = new List<ItemPedido>();
        }
        /// <summary>
        /// Obtem o cliente que realizou o pedido
        /// </summary>
        public Cliente Cliente { get; private set; }
        public DateTime Data { get; private set; }
        public List<ItemPedido> Itens { get; private set; }
        public double Total { get; private set; }

        /// <summary>
        /// Adiciona um item ao pedido e atualiza o valor total.
        /// </summary>
        /// <param name="item"></param>
        public void AdicionarItem (ItemPedido item)
        {
            Itens.Add(item);
            Total += item.Subtotal;
        }

        /// <summary>
        /// Retorna a Nome, Data e Total do Pedido
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Cliente: {Cliente.nome}, Data: {Data}, Total: {Total:F2}";
        }
    }
}