using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.SRP.Violacao
{
    public class Pedido
    {
        public Pedido(DateTime data, Cliente cliente)
        {
            this.Data = data;
            this.Cliente = cliente;

            this.Itens = new List<ItemDoPedido>();
        }

        public DateTime Data { get; private set; }
        public Cliente Cliente { get; private set; }
        public ICollection<ItemDoPedido> Itens { get; private set; }

        public void AdicionarItens(ItemDoPedido novoItem)
        {
            this.Itens.Add(novoItem);
        }

        public void Salvar()
        {
            //implementação de persistência
        }

        
    }
}
