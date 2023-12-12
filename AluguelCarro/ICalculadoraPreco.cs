using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro
{
    public interface ICalculadoraPreco
    {
        double CalcularPreco(Carro carro);
    }
}
