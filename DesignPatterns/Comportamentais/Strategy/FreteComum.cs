using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.Strategy
{
    internal class FreteComum : Frete
    {
        public float CalculaFrete(float valorPedido)
        {
            return valorPedido * 0.1f; //frete de 10% do valor do pedido para o frete comum
        }
    }
}
