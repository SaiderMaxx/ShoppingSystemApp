using ShoppingSystemApp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            mainController controller = new mainController();
            Engine engine = new Engine(controller);
            engine.Run();
        }
    }
}