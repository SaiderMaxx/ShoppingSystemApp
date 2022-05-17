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
            products = new List<Product>();
        }

        public double productsSum { get => this.products.Sum(p => p.Price); }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Receipt of {CustomerName}");
            sb.AppendLine($"Total Price: {this.productsSum:f2}");
            sb.Append("Products:");
            foreach (var prod in this.products)
            {
                sb.AppendLine();
                sb.Append(prod.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}
