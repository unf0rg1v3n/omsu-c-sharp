using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class MenuItemRecursiveCalc : MenuItemCore
    {
        const int DatesArrayLen = 4;
        static DateTime[] dates = new DateTime[4];
        public override string GetInfo()
        {
            return "Recursive calculator";
        }
        public override void Execute()
        {
            int N;

            DateRequest();

            Console.WriteLine("Entered dates:");
            for (int i = 0; i < DatesArrayLen; i = i + 2) 
            {
                Console.WriteLine($"{dates[i]} - {dates[i+1]}"); 
            }

            if ((dates[1] < dates[2]) || (dates[3] < dates[0]))
            {
                N = 0;
            }
            else
            {
                Array.Sort<DateTime>(dates);
                N = (dates[2] - dates[1]).Days + 1;
            }
            Console.WriteLine("Number of days in intersection: " + N);
            
            if (N <= 3)
            {
                Console.WriteLine("Result of Ackermann function: " + AckermannFunc(N, 5));
            }
            else
            {
                Console.WriteLine("Akcermann function cannot be evaluated.");
            }
        }
        static void DateRequest()
        {
            
            for (int i = 0; i < DatesArrayLen; i++)
            {
                Console.Write($"Enter { i + 1 } date in format dd.mm.yyyy: ");
                dates[i] = IOUtils.GetDate();
            }
            while (dates[0] > dates[1])
            {
                Console.Write("You've entered incorrect date: " +
                    "second date must be greater than first." +
                    "\nPlease, try again: ");
                dates[1] = IOUtils.GetDate();
            }
            while (dates[2] > dates[3])
            {
                Console.Write("You've entered incorrect date: " +
                    "second date must be greater than first." +
                    "\nPlease, try again: ");
                dates[3] = IOUtils.GetDate();
            }
        }
        static int AckermannFunc(int N, int m)
        {
            if (N == 0)
            {
                return m + 1;
            }
            else if (m == 0)
            {
                return AckermannFunc(N - 1, 1);
            }
            else
            {
                return AckermannFunc(N - 1, AckermannFunc(N, m - 1));
            }
        }
    }
}
