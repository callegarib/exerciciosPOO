using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispEletronicos
{
    public interface IDispositivoEletronico
    {
        void Ligar();
        void Desligar();
        bool StatusDispositivo();
    }
}
