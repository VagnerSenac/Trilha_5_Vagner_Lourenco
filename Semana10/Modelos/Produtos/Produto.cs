using System.Text.Json.Serialization;

namespace Comex.Modelos.Produtos
{
    /// <summary>
    /// Cadastro Base dos produtos
    /// </summary>
    public class Produto
    {

        public Produto(string nome)
        {
            Nome = nome;
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Nome { get; set; }

        [JsonPropertyName("price")]
        public double PrecoProdutos { get; set; }

        [JsonPropertyName("description")]
        public string DescricaoProduto { get; set; }

        public int Quantidade { get; set; }
    }
}