
using System.Text.Json;
using Comex.Modelos.Produtos;

namespace Comex.Menus
{
    public class MenuConsultarApiExterna
    {

        public async Task ConsultarApiExterna(List<Produto> listaDeProdutos)
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


                }
                catch (Exception)
                {
                    Console.WriteLine("Temos um problema \n");
                }
            }
        }

    }
}
