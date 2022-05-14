using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystemApp.Controller
{
    public class mainController
    {
        public mainController()
        {
        }
        public string ProcessProductCommand(List<string> args)
        {
            PhysicalProduct physicalProduct = new PhysicalProduct(args[0], int.Parse(args[1]), int.Parse(args[2]));
            return $"The current customer has bought {physicalProduct}.";
        }
        public string ProcessServiceCommand(List<string> args)
        {
            ServiceProduct serviceProduct = new ServiceProduct(args[0], int.Parse(args[1]), double.Parse(args[2]));
            return $"The current customer has bought {serviceProduct}.";
        }
        public string ProcessCheckoutCommand(List<string> args)
        {
            //Receipt receipt = new Receipt(args[0]);
            //foreach (var product in products)
            //{
            //receipt.AddProduct(product);
            //}
            //return $"Customer checked out for a total of ${sumOfProductPrices}.";
            return null;
        }
            public string ProcessInfoCommand(List<string> args)
        {
            // Console.WriteLine("Current customer has:");
            // Console.WriteLine($"Products: {countOfPhysicalProductsAndServiceProducts}");
            // Console.WriteLine($"Total Bill: ${ sumOfProductPrices}");
            return null;
        }
        public string ProcessEndCommand()
        {
            //Console.WriteLine($"Total customers today: {count}"); 
            return null;
        }
    }
}
