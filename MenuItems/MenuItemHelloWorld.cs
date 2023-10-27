using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class MenuItemHelloWorld : MenuItemCore
    {
        override public string GetInfo()
        {
            return "Hello world";
        }
        override public void Execute()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
