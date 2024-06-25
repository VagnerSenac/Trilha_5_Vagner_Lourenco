// See https://aka.ms/new-console-template for more information

//Produto produto = new Produto();
//produto.Nome = "Notebook";
//produto.Descricao = "Dell";
//produto.Quantidade = 100;
//produto.PrecoUnitario = 3500;

//Console.WriteLine(produto.Nome);
//Console.WriteLine(produto.Descricao);
//Console.WriteLine(produto.Quantidade);
//Console.WriteLine(produto.PrecoUnitario);

//Endereco endereco = new Endereco();
//endereco.Rua = "Av Brasil";
//endereco.Numero = 123;
//endereco.Cidade = "Americana";

//Cliente cliente = new Cliente();
//cliente.Nome = "Maria";
//cliente.CPF = "272.182.168-99";
//cliente.Endereco = endereco;

//Console.WriteLine(cliente.Nome);
//Console.WriteLine(cliente.CPF);
//Console.WriteLine(cliente.Endereco.Rua);


//Produto produto = new Produto("Chinelo");
//Produto produto1 = new Produto();
//Console.WriteLine(produto.Nome);    

using Comex;

var listaProdutos = new List<Produto>();


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

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 Criar Produto");
    Console.WriteLine("Digite 2 Listar Produto");
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
        case -1:
            Console.WriteLine("Finalizando!!");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
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

    Console.WriteLine("\nDigite a quabdidade do Produto: ");
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

ExibirOpcoesDoMenu();