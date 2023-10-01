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
		static Menu()
		{
			menuItems.Add(new MenuItemExit());
        }
		public static void Start()
		{
            while(true)
			{
                Menu.Show();
				menuItems[Menu.GetMenuItem()].Execute();
				Console.Write("\nPress any key to continue: ");
				Console.ReadKey();
				Console.Clear();
			}

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
		public static void Add(MenuItemCore item) { menuItems.Add(item); }
		public static void Remove(MenuItemCore item) {  menuItems.Remove(item); }
		public static void Clear() { menuItems.Clear();  }
	}
}
