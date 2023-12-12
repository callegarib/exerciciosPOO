using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrecos
{
    public class CalculadoraPrecoBase
    {
        public decimal CalcularPrecoBase(Produto produto)
        {
            return produto.Preco;
        }
    }
}
