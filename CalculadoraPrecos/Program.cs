using CalculadoraPrecos;
using System;
class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso das classes

        Produto produto = new Produto { Nome = "Produto de Natal", Preco = 100 };

        CalculadoraPrecoBase calculadoraPrecoBase = new CalculadoraPrecoBase();
        decimal precoBase = calculadoraPrecoBase.CalcularPrecoBase(produto);

        AplicadorDesconto aplicadorDesconto = new AplicadorDesconto();
        decimal precoComDesconto = aplicadorDesconto.AplicarDesconto(produto, precoBase);

        CalculadoraPrecoFinal calculadoraPrecoFinal = new CalculadoraPrecoFinal();
        decimal precoFinal = calculadoraPrecoFinal.CalcularPrecoFinal(precoComDesconto, "pix");

        Console.WriteLine($"Preço final do produto: R$ {precoFinal:F2}");

        Loja loja = new Loja();
        loja.MostrarProdutos();
    }
}