using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardaChuva
{
    public class GuardaChuva
    {
        public virtual void Abrir()
        {
            Console.WriteLine("Guarda-chuva aberto.");
        }

        public virtual void Fechar()
        {
            Console.WriteLine("Guarda-chuva fechado.");
        }
    }
}
