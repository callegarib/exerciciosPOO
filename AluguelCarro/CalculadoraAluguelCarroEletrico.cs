using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro;

public class CalculadoraAluguelCarroEletrico : ICalculadoraPreco
{
    public double CalcularPreco(Carro carro)
    {
        double preco = 0;
        var carroEletrico = carro as CarroEletrico;
        if (carroEletrico != null && carroEletrico.Ano >= 2020 && carroEletrico.AutonomiaBateria > 300)
        {
            preco = 150; // Preço base + 50 para carros elétricos com autonomia > 300 km
        }
        else
        {
            preco = 100; // Preço base para carros elétricos
        }
        return preco;
    }
}