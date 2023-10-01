using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
	static class Menu
	{
		static List<MenuItemCore> menuItems = new List<MenuItemCore>();
		public static bool key = true; // ключ выхода из программы
		static Menu()
		{
			menuItems.Add(new MenuItemExit());
        }
		public static void Start()
		{
            key = true;
            do
			{
                Menu.Show();
				menuItems[Menu.GetMenuItem()].Execute();
				Console.Clear();
			} while (key);

        }
		// Вывод каждого пункта меню в консоль
		static void Show()
		{
			for (int i = 0; i < menuItems.Count; i++)
			{ 
				Console.WriteLine($"[{i}] " + menuItems[i].GetInfo());
            }
            Console.Write("\nSelect menu item: ");
        }
		// получение пункта меню
		static int GetMenuItem()
		{
			int res;
			while (true)
			{
				res = ConsoleIOUtils.GetInt();
				if (res < 0 || res >= menuItems.Count)
				{
                    Console.WriteLine("Enter correct value: ");
					continue;
                }
                return res;
            }
		}
	}
}
