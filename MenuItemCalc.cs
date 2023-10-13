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
            x = IOUtils.GetDouble();
            Console.Write("Enter y: ");
            y = IOUtils.GetDouble();
            Console.Write("Enter z: ");
            while ((z = IOUtils.GetDouble()) == 0) { Console.Write("Enter correct value: "); }
            Console.WriteLine("Result: " + x * y % z);
        }
    }
}
