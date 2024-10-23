using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    internal class Product
    {
        private string _name;
        private double _price;

        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public string Name // this is the property
        {
            get { return _name ; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; } // Getter returns the private field
            private set // Private setter to restrict modification from outside the class
            {
                _price = value; // Allows modification only within the class
            }
        }
    }
}
