using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystemApp
{
    class ServiceProduct : Product
    {
        private string name;
        private double price;
        private double time;
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

        public double Time
        {
            get { return time; }
            private set {
                if (value <= 0)
                {
                    throw new ArgumentException("Time should be greater than 0!");
                }
                time = value; 
            }
        }

        public ServiceProduct(string name, double price, double time) : base(name, price)
        {
            Name = name;
            Price = price;
            Time = time;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nPrice: {Price} \nTime: {Time}";
        }
    }
}
