using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystemApp
{
    public class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null!");
                }
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Name should be between 3 and 30 characters!");
                }
                name = value;
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            private set { 
                if(value <= 0)
                {
                    throw new ArgumentNullException("Price should be 0 or positive!");
                }
                price = value; 
            }
        }


        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nPrice: {Price}";
        }
    }
}
