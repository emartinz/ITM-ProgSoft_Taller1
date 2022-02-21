using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    internal class ComposedProduct : Product
    {
        public float Discount { get; set; }

        public List<Product> Products { get; set; }

        public override decimal GetValueToPay()
        {
            decimal Sum = 0;
            Products.ForEach(
                p => Sum += p.GetValueToPay()
            );

            return Sum - (Sum * (Decimal)Discount);
        }

        public override string ToString()
        {
            String strProducts = string.Join(", ", Products.Select(P => P.Description));

            return $"{ base.ToString()}" +
                $"\n{$" ",7}Products...: {$"{strProducts}", 50}" +
                $"\n{$" ",7}Discount...: {$"{Discount:P2}",15}" +
                $"\n{$" ",7}Value......: {$"{GetValueToPay():C2}",14}";
        }
    }
}
