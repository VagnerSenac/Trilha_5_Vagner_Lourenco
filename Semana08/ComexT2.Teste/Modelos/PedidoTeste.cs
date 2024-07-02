using Comex.Modelos.Cliente;
using Comex.Modelos.Produtos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ComexT2.Teste.Modelos
{
    public class PedidoTeste
    {
        [Fact]
        public void PedidoDeveInicializarComClienteeDataCorreta()
        {
            // Arrange
            var cliente = new Cliente { nome = "Vagner" };
            //Act
            var pedido = new Pedido(cliente);
            //Assert
            Assert.Equal(cliente, pedido.Cliente);
            Assert.Empty(pedido.Itens);
            Assert.Equal(0, pedido.Total);
        }
        [Theory]
        [InlineData("Produo X", 400.0, 2)]
        [InlineData("Produo y", 500.0, 1)]
        [InlineData("Produo z", 600.0, 3)]
        public void AdicionarItemeAtualizarTotal(string nomeProduto, double preUnitario, int quantidade)
        {
            //Arrange
            var cliene = new Cliente { nome =" VAgner "};
            var pedido = new Pedido(cliene);
            var produto = new Produto(nomeProduto) { precoProdutos = preUnitario};
            var item = new ItemPedido(produto, quantidade);
            var totalEsperado = preUnitario * quantidade;

            //Act
            pedido.AdicionarItem(item);


            //Assert
            Assert.Contains(item, pedido.Itens);
            Assert.Equal(totalEsperado, pedido.Total);

        }

        public void ToStringDeveRetornarSring(Cliente cliente)
        {
            //Arrange
            var cliene = new Cliente { nome = " VAgner " };
            var pedido = new Pedido(cliene);
            var produto = new Produto("Produto Z") { precoProdutos = 100.0 };
            var item = new ItemPedido(produto, 2);
            pedido.AdicionarItem(item);

            var stringEsperada = $"Cliente: {cliente.nome}, Data: {pedido.Data}, Total: {pedido.Total:F2}";

            //Act
            var result = pedido.ToString();


            //Assert
            Assert.Equal(stringEsperada,result);
        

        }
    }
























































}