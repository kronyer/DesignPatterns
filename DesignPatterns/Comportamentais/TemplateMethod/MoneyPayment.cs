using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.TemplateMethod
{
    public class MoneyPayment : Payment
    {
        public MoneyPayment(int value, Gateway gateway) : base(value, gateway)
        {
        }
        public override int CalculateDiscount()
        {
            return (int)(Value * 0.15);
        }
    }
}
