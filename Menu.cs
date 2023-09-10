using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
	internal class Menu
	{
		public static void Start()
		{
			while (true)
			{
				Console.WriteLine("[0] Exit\n" +
								"[1] Hello World!\n" +
								"[2] Calc: x * y % z");
				Console.Write("\nSelect menu item: ");

				switch (Menu.GetMenuItem())
				{
					case -1: 
						Console.Clear();
						Console.WriteLine("This menu item doesn't exist.");
						continue;

					case 0: 
						return;

					case 1:
						Console.Clear(); 
						Item1();
						break;

					case 2:
						Console.Clear();
						Item2();
						break;

					default: 
						Console.Clear();
						Console.WriteLine("This menu item doesn't exist.\n");
						break;
				}
			}
		}

		static void Item1()
		{
            Console.Write("Hello World!\n" +
				"\nPress any key to return: ");
			Console.ReadKey();
			Console.Clear();

			return;
        }
		static void Item2()
		{
			Console.Write("Please, enter double x: ");
			double x = GetVar();

            Console.Write("Please, enter double y: ");
            double y = GetVar();

            Console.Write("Please, enter double z: ");
            double z = GetVar();

			Console.WriteLine(x * y % z);

            Console.Write("\nPress any key to return: ");
            Console.ReadKey();
            Console.Clear();
        }

		static double GetVar()
		{
			while (true)
			{
				double var;

				if (double.TryParse(Console.ReadLine(), out var))
				{
					return var;
				}
				Console.Write("\nYou've entered incorect data, try again: ");
			}
		}
		static int GetMenuItem()
		{
			int res;
			return int.TryParse(Console.ReadLine(), out res) ? res : -1;
        }
	}
}
