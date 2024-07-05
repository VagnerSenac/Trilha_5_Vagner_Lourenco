namespace Comex.Modelos.Produtos;
/// <summary>
/// Itens de Cadastro expecífico de cadastro de produtos eletônicos
/// </summary>
internal class Eletronico : Produto
{
    public Eletronico(string nome) : base(nome)
    {
    }

    public int Voltagem { get; set; }
    public int Potencia { get; set; }
}
