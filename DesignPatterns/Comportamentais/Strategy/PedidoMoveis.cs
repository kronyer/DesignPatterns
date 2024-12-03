using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.Strategy
{
    public class PedidoMoveis : Pedido
    {
        public string NomeSetor { get; set; }

        public PedidoMoveis()
        {
            NomeSetor = "Móveis";
        }

        public string GetNomeSetor()
        {
            return NomeSetor;
        }

        public void SetNomeSetor(string nomeSetor)
        {
            NomeSetor = nomeSetor;
        }
        public enum TipoFrete
        {
            Comum,
            Expresso
        }
    }
}
