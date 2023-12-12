using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPrecos
{
    public class CalculadoraPrecoFinal
    {
        public decimal CalcularPrecoFinal(decimal precoComDesconto, string meioDePagamento)
        {
            if (meioDePagamento.ToLower() == "pix")
            {
                // Desconto adicional de 10% para pagamento com PIX
                return precoComDesconto - (precoComDesconto * 10 / 100);
            }
            else if (meioDePagamento.ToLower() == "cartão de crédito")
            {
                // Acréscimo de 5% para pagamento com cartão de crédito
                return precoComDesconto + (precoComDesconto * 5 / 100);
            }
            else
            {
                return precoComDesconto;
            }
        }
    }
}
