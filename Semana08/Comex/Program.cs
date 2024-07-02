using Comex.Modelos.Cliente;
using Comex.Modelos.Produtos;
using System.Net.Http.Json;
using System.Text.Json;

var listaPedidos = new List<Pedido>();
var listaProdutos = new List<Produto>
{
    new Produto("Notebook")
    {
        descricaoProduto = "Notebook Dell",
        precoProdutos = 3500.00,
        Quantidade = 10
    },
    new Produto("Telado")
    {
        descricaoProduto = "Dell",
        precoProdutos = 30.00,
        Quantidade = 10
    },
    new Produto("Mouse")
    {
        descricaoProduto = "Microsoft",
        precoProdutos = 200.00,
        Quantidade = 100
    },
    new Produto("Monitor")
    {
        descricaoProduto = "AOC",
        precoProdutos = 500.00,
        Quantidade = 10
    },
    new Produto("Fonte")
    {
        descricaoProduto = "China",
        precoProdutos = 50.00,
        Quantidade = 100
    }

};


void ExibirLogo()
{
    Console.WriteLine(@"
────────────────────────────────────────────────────────────────────────────────────────
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██████████████░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██░░██████████─██░░██████░░██─██░░░░░░░░░░░░░░░░░░██─██░░██████████─████░░██──██░░████─
─██░░██─────────██░░██──██░░██─██░░██████░░██████░░██─██░░██───────────██░░░░██░░░░██───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──██░░██──██░░██─██░░░░░░░░░░██─────██░░░░░░██─────
─██░░██─────────██░░██──██░░██─██░░██──██████──██░░██─██░░██████████───████░░░░░░████───
─██░░██─────────██░░██──██░░██─██░░██──────────██░░██─██░░██───────────██░░░░██░░░░██───
─██░░██████████─██░░██████░░██─██░░██──────────██░░██─██░░██████████─████░░██──██░░████─
─██░░░░░░░░░░██─██░░░░░░░░░░██─██░░██──────────██░░██─██░░░░░░░░░░██─██░░░░██──██░░░░██─
─██████████████─██████████████─██████──────────██████─██████████████─████████──████████─
────────────────────────────────────────────────────────────────────────────────────────");
    Console.WriteLine("Boas Vindas ao Comex!!!");
}


async Task ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 Criar Produto");
    Console.WriteLine("Digite 2 Listar Produto");
    Console.WriteLine("Digite 3 Consultar a API Externa");
    Console.WriteLine("Digite 4 Criar Pedido");
    Console.WriteLine("Digite 5 Listar Pedidos");
    Console.WriteLine("Digite -1 para Sair");
    Console.WriteLine("\nDigite a sua Opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            CriarProduto();
            break;
        case 2:
            ListarProdutos();
            break;
        case 3:
            await ConsultarApiExterna();
            break;
        case 4:
            CriarPedido();
            break;
        case 5:
            ListarPedidos();
            break;

        case -1:
            Console.WriteLine("Finalizando!!");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

async Task ListarPedidos()
{
    Console.Clear();
    Console.WriteLine("Listando Todos os pedidos criados \n");

    var pedidosOrdenados = listaPedidos.OrderBy(p => p.Cliente.nome).ToList();

    foreach (var pedido in pedidosOrdenados)

    {
        Console.WriteLine($"Pedido {pedido}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpcoesDoMenu();
}

async Task CriarPedido()
{
  
    Console.Clear();
    Console.WriteLine("Criando um novo Pedido \n");

    Console.WriteLine("Digite o nome do Cliente: ");
    string nomeCliente = Console.ReadLine();
    var cliente = new Cliente();
    cliente.nome = nomeCliente;

    var pedido = new Pedido(cliente);

    Console.WriteLine("\nProdutos Disponíveis: ");
    for (int i = 0; i < listaProdutos.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {listaProdutos[i].Nome}");
    }
    Console.WriteLine("Digite o número do produto que deseja adicionar: ");
    int numeroProduto = int.Parse(Console.ReadLine());
    var produto = listaProdutos[numeroProduto -1];

    Console.WriteLine("Digite a quanidade desejada: ");
    var quantidade = int.Parse(Console.ReadLine());

    var itemdePedido = new ItemPedido(produto, quantidade);
    pedido.AdicionarItem(itemdePedido);
    Console.WriteLine($"Item adicionado com Sucesso!\n");
    listaPedidos.Add(pedido);
    Console.WriteLine($"Pedido criado com Sucesso!\n");
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    await ExibirOpcoesDoMenu();

}

async Task ConsultarApiExterna()
{
    using (HttpClient client = new HttpClient())
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Exebindo Produtos da API Externa \n");
            string resposta = await client.GetStringAsync("https://fakestoreapi.com/products");
            var produtos = JsonSerializer.Deserialize<List<Produto>>(resposta);

            foreach (var produto in produtos)
            {
                Console.WriteLine($"\nNome: {produto.Nome}" + $"\nDescrição: {produto.descricaoProduto}" + $"\nPreço: {produto.precoProdutos}");

            }
            

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
            await ExibirOpcoesDoMenu();

        }
        catch (Exception )
        {
            Console.WriteLine("Temos um problema \n");
        }
    }
}

void CriarProduto()
{
    Console.Clear();
    Console.WriteLine("Registro de Produto");
    Console.WriteLine("\nDigite o nome do Produto: ");
    string nomeProduto = Console.ReadLine();

    var Produto = new Produto(nomeProduto);

    Console.WriteLine("\nDigite a descrição do Produto: ");
    string descricaoProduto = Console.ReadLine();
    Produto.descricaoProduto =  descricaoProduto;

    Console.WriteLine("\nDigite o preço do Produto: ");
    string precoProdutos = Console.ReadLine();
    Produto.precoProdutos = double.Parse(precoProdutos);

    Console.WriteLine("\nDigite a quantidade do Produto: ");
    string quantidadeProduto = Console.ReadLine();
    Produto.Quantidade= int.Parse(quantidadeProduto);

    listaProdutos.Add(Produto);
    Console.WriteLine($"O Produto foi Cadastrado");
    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ListarProdutos()
{
    Console.Clear();
    Console.WriteLine("Lista de Produto");

    foreach (var produto in listaProdutos)
    {
        Console.WriteLine($"Produto: {produto.Nome}, "+ $"Descrição: {produto.precoProdutos}, "+ $"Preço: {produto.precoProdutos}, " + $"Quantidade: {produto.Quantidade}, ");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

await ExibirOpcoesDoMenu();

//Livro teste = new Livro("O Senho dos Anéis");
//teste.Isbn = "123456789";
//string indentificacaoTeste = teste.Identificavel();
//Console.WriteLine(indentificacaoTeste);

