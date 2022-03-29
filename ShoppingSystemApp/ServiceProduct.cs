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

        private double time;

        public double Time
        {
            get { return time; }
            private set {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Time should be greater than 0!");
                }
                time = value; 
            }
        }

        public ServiceProduct(string name, double price, double time) : base(name, price)
        {
        }

        public override string ToString()
        {
            return $"Name: {Name} \nPrice: {Price} \nTime: {Time}";
        }
    }
}
