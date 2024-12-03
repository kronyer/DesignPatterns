using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.Strategy
{
    public class PedidoEletronicos : Pedido // The inheritance in Pedido allows different types of orders
                                                     // (e.g., PedidoEletronicos, PedidoMoveis) to share common behavior for
                                                     // setting and getting the freight calculation strategy and calculating
                                                     // the freight cost.
    {
        public string NomeSetor { get; set; }

        public PedidoEletronicos()
        {
            NomeSetor = "Eletrônicos";
        }

        public string GetNomeSetor()
        {
            return NomeSetor;
        }

        public void SetNomeSetor(string nomeSetor)
        {
            NomeSetor = nomeSetor;
        }
    }
}
