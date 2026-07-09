using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.ClasesObjetos
{
    public class Product
    {

        public string Name;
        public decimal Price;
        public int Stock;

        public Product(string Name, decimal Price, int Stock)
        {
            this.Name = Name;
        }

        public Product(string Name, decimal Price) : this(Name, Price, 0) {}
    }
}