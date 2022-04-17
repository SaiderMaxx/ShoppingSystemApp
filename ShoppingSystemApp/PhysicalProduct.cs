using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystemApp
{
    class PhysicalProduct : Product
    {
        private string name;
        private double price;
        private double weight;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public double Weight
        {
            get { return weight; }
            private set {
                if (value <= 0)
                {
                    throw new ArgumentException("Weight should be positive!");
                }
                weight = value; 
            }
        }
        public PhysicalProduct(string name, double price, double weight) : base(name, price)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nPrice: {Price} \nWeight: {Weight}";
        }
    }
}
