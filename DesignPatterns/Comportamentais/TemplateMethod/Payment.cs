using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.TemplateMethod
{
    public abstract class Payment
    {
        protected int Value { get;  set; }
        private Gateway Gateway { get; set; }

        public Payment(int value, Gateway gateway)
        {
            Value = value;
            Gateway = gateway;
        }


        //Esse é um hook
        public virtual int CalculateTaxes()
        {
            return 0;
        }

        public abstract int CalculateDiscount();


        //ESSE É o TEMPLATE!!!!
        public bool RealizeCharge()
        {
            int totalValue = Value - CalculateDiscount() + CalculateTaxes();

            Console.WriteLine("Calculando desconto - R$" + totalValue.ToString());

            return Gateway.Charge(totalValue);
        }
    }
}
