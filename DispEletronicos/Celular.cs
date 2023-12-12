using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispEletronicos
{
    public class Celular : IDispositivoEletronico
    {
        private bool Status { get; set; }

        public void Desligar()
        {
            Status = false;
        }

        public void Ligar()
        {
            Status = true;
        }

        public bool StatusDispositivo()
        {
            return Status;
        }
    }
}
