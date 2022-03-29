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

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            private set {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Weight should be positive!");
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
