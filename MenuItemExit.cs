using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class MenuItemExit : MenuItemCore
    {
        public override string GetInfo()
        {
            return "Exit";
        }
        public override void Execute()
        {
            Environment.Exit(0);

            return;
        }
    }
}
