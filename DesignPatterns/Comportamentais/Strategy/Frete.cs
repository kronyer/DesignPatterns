using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.Strategy
{
    public interface Frete
    {
        public float CalculaFrete(float valorPedido);
    }
}
