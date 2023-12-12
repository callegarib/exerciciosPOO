using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrecos
{
    public class AplicadorDesconto
    {
        public decimal AplicarDesconto(Produto produto, decimal precoBase)
        {
            decimal desconto = 0;

            if (produto.Nome.ToLower().Contains("natal"))
            {
                desconto = 20;
            }
            else
            {
                desconto = 15;
            }

            return precoBase - (precoBase * desconto / 100);
        }
    }
}
