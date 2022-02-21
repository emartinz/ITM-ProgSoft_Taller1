using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    public abstract class Product
    {
        public int Id { get; set; }

        public String Description { get; set; }
        
        public decimal Price { get; set; }

        public float Tax { get; set; }

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{$"{Id}",-6} {Description}";
        }
    }
}
