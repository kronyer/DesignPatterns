using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Comportamentais.TemplateMethod
{
    public class DebitPayment : Payment
    {
        public DebitPayment(int value, Gateway gateway) : base(value, gateway)
        {
        }
        public override int CalculateDiscount()
        {
            return (int)(Value * 0.1);
        }
        public override int CalculateTaxes()
        {
            return (int)(Value * 0.05);
        }
    }
}
