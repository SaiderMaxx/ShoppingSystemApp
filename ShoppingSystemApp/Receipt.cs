using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystemApp
{
    class Receipt
    {
        private string customerName;
        List<Product> products;

        public string CustomerName
        {
            get { return customerName; }
            private set {
                if (value.Length < 2 || value.Length > 40)
                {
                    throw new ArgumentOutOfRangeException("Customer Name should be between 2 and 40 characters!");
                }
                customerName = value;
            }
        }

        public Receipt(string customerName)
        {
            CustomerName = customerName;
        }

        public override string ToString()
        {
            return "";
            // TODO
            // return $"Receipt of {CustomerName} \nTotal Price: {sumOfProductPrices} \nProducts:";
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
