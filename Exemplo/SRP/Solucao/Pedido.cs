
using System;
using System.Collections.Generic;

namespace Exemplo.SRP.Solucao
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

    }


}
