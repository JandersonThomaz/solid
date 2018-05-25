using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.OCP.Violacao
{
    public class Conta
    {
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public decimal Saldo { get; private set; }
        public string Titular { get; private set; }
        public TipoConta Tipo { get; private set; }


        public void Sacar(decimal valor)
        {
            if(this.Tipo == TipoConta.Corrente)
            {
                if(valor > this.Saldo)
                {
                    throw new Exception("Saldo Insuficiente!");
                }

                this.Saldo -= valor;
            }
            else if(this.Tipo == TipoConta.Poupanca)
            {
                if(valor + 0.10m > this.Saldo)
                {
                    throw new Exception("Saldo Insuficiente!");
                }

                this.Saldo -= valor + 0.10m;
            }
        }


    }
}
