using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.Strategy
{
    public abstract class Pedido
    {
        public float Valor { get; set; }
        public Frete TipoFrete { get; set; } //Strategies as interface


        public float GetValor()
        {
            return Valor;
        }

        public void SetValor(float valor)
        {
            Valor = valor;
        }

        public void SetTipoFrete(Frete frete)
        {
            TipoFrete = frete;
        }

        public float CalculaFrete()
        {
            if (TipoFrete == null)
            {
                throw new InvalidOperationException("TipoFrete não foi definido.");
            }
            return TipoFrete.CalculaFrete(Valor); //It depends on the strategy injected
        }
    }


}
