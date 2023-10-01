using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class MenuItemCalc : MenuItemCore
    {
        public override string GetInfo()
        {
            return "Calc: x * y % z";
        }
        public override void Execute()
        {
            double x, y, z;
            Console.Write("Enter x: ");
            x = ConsoleIOUtils.GetDouble();
            Console.Write("Enter y: ");
            y = ConsoleIOUtils.GetDouble();
            Console.Write("Enter z: ");
            while ((z = ConsoleIOUtils.GetDouble()) == 0) { Console.Write("Enter correct value: "); }
            Console.WriteLine("Result: " + x * y % z);
        }
    }
}
