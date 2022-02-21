using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    internal class Invoice
    {
        private List<Product> _products = new();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        
        public decimal GetValueToPay()
        {
            decimal Sum = 0;
            _products.ForEach(
                p => Sum += p.GetValueToPay()
            );

            return Sum;
        }

        public override string ToString()
        {
            return $"RECEIPT" +
                $"\n-------------------------------------------------" +
                $"\n{string.Join("\n", _products)}" +
                $"\n{$" ",18} ===============" +
                $"\n{$"TOTAL: ", -19} {$"{GetValueToPay():C2}",14}"; 
        }
    }
}
