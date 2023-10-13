using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
	internal class Program
	{
	    static void Main(string[] args)
		{
            Menu.Add(new MenuItemHelloWorld());
            Menu.Add(new MenuItemCalc());
            Menu.Add(new MenuItemRecursiveCalc());
            Menu.Start();
        }
        
    }
}
