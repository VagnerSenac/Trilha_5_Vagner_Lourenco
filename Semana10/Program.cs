using Comex.Data;
using Comex.Menus;
using Comex.Modelos.Cliente;
using Comex.Modelos.Produtos;
using System.Net.Http.Json;
using System.Text.Json;

var listaPedidos = new List<Pedido>();
var listaDeProdutos = new List<Produto>
{
    new Produto("Notebook")
    {
        DescricaoProduto = "Notebook Dell",
        PrecoProdutos = 3500.00,
        Quantidade = 10
    },
    new Produto("Telado")
    {
        DescricaoProduto = "Dell",
        PrecoProdutos = 30.00,
        Quantidade = 10
    },
    new Produto("Mouse")
    {
        DescricaoProduto = "Microsoft",
        PrecoProdutos = 200.00,
        Quantidade = 100
    },
    new Produto("Monitor")
    {
        DescricaoProduto = "AOC",
        PrecoProdutos = 500.00,
        Quantidade = 10
    },
    new Produto("Fonte")
    {
        DescricaoProduto = "China",
        PrecoProdutos = 50.00,
        Quantidade = 100
    }

};

MenuCriarProduto menuCriarProduto = new MenuCriarProduto();
MenuCriarPedido menuCriarPedido = new MenuCriarPedido();
MenuListarPedidos menuListarPedidos = new MenuListarPedidos();
MenuListarPorPreco menuListarPorPreco = new MenuListarPorPreco();
MenuListarProdutos menuListarProdutos = new MenuListarProdutos();
MenuOrdemDeProdutoPeloTitulo menuOrdemDeProdutoPeloTitulo = new MenuOrdemDeProdutoPeloTitulo();
MenuConsultarApiExterna menuConsultarApiExterna = new MenuConsultarApiExterna();

ProdutoDAL produtoDAL = new ProdutoDAL();

ComexDbContext comexDbContext = new ComexDbContext();
ProdutoRespository produtoRepository = new ProdutoRespository(comexDbContext);


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
    Console.WriteLine("Digite 6 Ordenar Produtos pelo Título");
    Console.WriteLine("Digite 7 Ordenar Produtos pelo Preço");
    Console.WriteLine("Digite -1 para Sair");
    Console.WriteLine("\nDigite a sua Opção: ");
    string OpcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(OpcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            menuCriarProduto.CriarProduto(produtoRepository);
            await ExibirOpcoesDoMenu();
            break;
        case 2:
            menuListarProdutos.ListarProdutos(produtoRepository);
            await ExibirOpcoesDoMenu();
            break;
        case 3:
            await menuConsultarApiExterna.ConsultarApiExterna(listaDeProdutos);
            await ExibirOpcoesDoMenu();
            break;
        case 4:
            menuCriarPedido.CriarPedido(listaDeProdutos,listaPedidos);
            await ExibirOpcoesDoMenu();
            break;
        case 5:
            menuListarPedidos.ListarPedidos(listaDeProdutos, listaPedidos);
            await ExibirOpcoesDoMenu();
            break;
        case 6:
            menuOrdemDeProdutoPeloTitulo.OrdemDeProdutoPeloTitulo(listaDeProdutos);
            await ExibirOpcoesDoMenu();
            break;
        case 7:
            menuListarPorPreco.listarPorPreco(listaDeProdutos);
            await ExibirOpcoesDoMenu();
            break;
        case -1:
            Console.WriteLine("Finalizando!!");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}
await ExibirOpcoesDoMenu();

