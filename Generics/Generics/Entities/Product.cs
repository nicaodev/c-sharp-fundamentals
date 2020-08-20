using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Generics.Entities
{

    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
                throw new ArgumentException($"{obj} Não é do tipo Product");

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


