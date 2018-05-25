using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.DIP.Violacao
{
    public class Botao
    {
        private Lampada lampada;

        public Botao(Lampada lampada)
        {
            this.lampada = lampada;
        }

        public void Acionar()
        {
            lampada.Ligar();
        }
    }
}
