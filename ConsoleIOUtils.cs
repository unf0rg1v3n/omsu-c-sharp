using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    static class ConsoleIOUtils
    {
        public static int GetInt()
        {
            int res;
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                Console.Write("Enter coorreсt value: ");
            }
            
            return res;
        }
        public static double GetDouble()
        {
            double res;
            while (!double.TryParse(Console.ReadLine(), out res))
            {
                Console.Write("Enter coorreсt value: ");
            }

            return res;
        }
    }
    
}
