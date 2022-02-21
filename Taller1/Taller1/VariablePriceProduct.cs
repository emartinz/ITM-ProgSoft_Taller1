using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    internal class VariablePriceProduct:Product
    {
        public String Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal GetValueToPay()
        {
            return (Price * (Decimal)Quantity) * (1 + (Decimal)Tax);
        }

        public override string ToString()
        {
            return $"{ base.ToString()}" +
                $"\n{$" ",7}Measurement: {Measurement}" +
                $"\n{$" ",7}Quantity...: {$"{Quantity:N2}",14}" +
                $"\n{$" ",7}Price......: {$"{Price:C2}",14}" +
                $"\n{$" ",7}Tax........: {$"{Tax:P2}",15}" +
                $"\n{$" ",7}Value......: {$"{GetValueToPay():C2}",14}";
        }
    }
}
