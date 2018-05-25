using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.OCP.Solucao
{
    public class ContaCorrente : Conta
    {
        public override void Sacar(decimal valor)
        {
            if(valor > this.Saldo)
            {
                throw new Exception("Saldo Insuficiente!");
            }

            this.Saldo -= valor;
        }
    }
}
