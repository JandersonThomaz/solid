using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.DIP.Solucao
{
    public class Teste
    {
        public void Testar()
        {
            var botao = new Botao(new Celular());

            botao.Acionar();
        }
    }
}
