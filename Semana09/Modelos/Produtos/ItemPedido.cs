

namespace Comex.Modelos.Produtos
{
    public class ItemPedido
    {
        /// <summary>
        /// Levantamento de informações de um Pedido
        /// </summary>
        /// <param name="produto"></param>
        /// <param name="quantidade"></param>
        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public ItemPedido(Produto produto, int quanidade, double precoUnitario)
        {
            Produto = produto;
            Quantidade = quanidade;
            this.precoUnitario = precoUnitario;
            Subtotal = quanidade * precoUnitario;
        }

        public Produto Produto { get; private set; }
        public int Quantidade { get; private set; }
        public double precoUnitario { get; private set; }
        public double Subtotal { get; private set; }

        public override string ToString()
        {
            return $"Produto: {Produto.Nome}, Quantidade: {Quantidade}," + $"Preço Unitário: {precoUnitario:F2}, SubTotal:{Subtotal:F2}";
        }
    }
}
