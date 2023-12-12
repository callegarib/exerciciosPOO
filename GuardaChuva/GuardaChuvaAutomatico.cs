using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuardaChuva
{
    public class GuardaChuvaAutomatico : GuardaChuva
    {
        private bool _estaAberto;

        public override void Abrir()
        {
            Console.WriteLine("Guarda-chuva automático abrindo.");
            _estaAberto = true;
        }

        public override void Fechar()
        {
            Console.WriteLine("Guarda-chuva automático fechando.");
            _estaAberto = false;
        }

        public void Agitar()
        {
            if (_estaAberto)
            {
                Console.WriteLine("Guarda-chuva automático agitado.");
            }
            else
            {
                Console.WriteLine("Não é possível agitar um guarda-chuva fechado.");
            }
        }
    }
}
