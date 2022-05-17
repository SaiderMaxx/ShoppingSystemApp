using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystemApp.Controller
{
    public class mainController
    {
        private List<Product> products;
        private List<Receipt> receipts;
        public mainController()
        {
            products = new List<Product>();
            receipts = new List<Receipt>();
        }
        public string ProcessProductCommand(List<string> args)
        {
            Product physicalProduct = new PhysicalProduct(args[0], double.Parse(args[1]), double.Parse(args[2]));
            products.Add(physicalProduct);
            return $"The current customer has bought {physicalProduct}.";
        }
        public string ProcessServiceCommand(List<string> args)
        {
            Product serviceProduct = new ServiceProduct(args[0], double.Parse(args[1]), double.Parse(args[2]));
            products.Add(serviceProduct);
            return $"The current customer has bought {serviceProduct}.";
        }
        public string ProcessCheckoutCommand(List<string> args)
        {
            Receipt receipt = new Receipt(args[0]);
            foreach (var product in products)
            {
                receipt.AddProduct(product);
            }
            receipts.Add(receipt);
            products.Clear();
            return $"Customer checked out for a total of ${receipt.productsSum:f2}.";
        }
        public string ProcessInfoCommand(List<string> args)
        {
            StringBuilder sb = new StringBuilder();
            if (args[0].Equals("Customer"))
            {
                sb.AppendLine("Current customer has:");
                sb.AppendLine($"Products: {this.products.Count}");
                sb.AppendLine($"Total Bill: ${this.products.Sum(p => p.Price):f2}");
            }
            else if (args[0].Equals("Shop"))
            {
                if (this.receipts.Count > 0)
                {
                    sb.AppendLine("Receipts:");
                    sb.AppendLine("");
                    foreach (var rec in this.receipts)
                    {
                        sb.AppendLine(rec.ToString());
                    }
                }
                else
                {
                    sb.AppendLine("Receipts: No receipts");
                }
            }
            else
            {
                var currentCustomer = this.receipts.Where(r => r.CustomerName.Equals(args[0])).FirstOrDefault();
                sb.AppendLine(currentCustomer.ToString());
            }

            return sb.ToString();
        }
        public string ProcessEndCommand()
        {
            return $"Total customers today: {this.receipts.Count}";
        }
    }
}
