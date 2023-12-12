using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro
{
    public class CalculadoraAluguelPadrao : ICalculadoraPreco
    {
        public double CalcularPreco(Carro carro)
        {
            double preco = 0;
            if (carro.Ano >= 2020)
            {
                preco = 100;
            }
            else
            {
                preco = 50;
            }
            return preco;
        }
    }
}
