using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Item3 : MenuItemCore
    {
        public override string GetInfo()
        {
            return "Calc: x * y % z";
        }
        public override void Execute()
        {
            double x, y, z;
            x = ConsoleIOUtils.GetDouble();
            y = ConsoleIOUtils.GetDouble();
            while((z = ConsoleIOUtils.GetDouble()) == 0) { Console.WriteLine("Enter correct value: "); }
            Console.WriteLine("Result: " + x * y % z);
        }
    }
}
