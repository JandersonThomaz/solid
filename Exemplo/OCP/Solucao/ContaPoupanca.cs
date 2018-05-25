using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.OCP.Solucao
{
    public class ContaPoupanca : Conta
    {
        public override void Sacar(decimal valor)
        {
            if(valor + 0.10m > this.Saldo)
            {
                throw new Exception("Saldo Insuficiente!");
            }

            this.Saldo -= valor + 0.10m;
        }
    }
}
