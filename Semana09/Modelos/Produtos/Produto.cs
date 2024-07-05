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
        [JsonPropertyName("title")]
        public string Nome { get; set; }

        [JsonPropertyName("price")]
        public double precoProdutos { get; set; }

        [JsonPropertyName("description")]
        public string descricaoProduto { get; set; }

        public int Quantidade { get; set; }
    }
}