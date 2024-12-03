using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.Strategy
{
    internal class FreteExpresso : Frete
    {
        public float CalculaFrete(float valorPedido)
        {
            return valorPedido * 0.2f; //For the express freight, the value is 20% of the order value
        }
    }
}
