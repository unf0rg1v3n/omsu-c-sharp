using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    static class IOUtils
    {
        
        public static int GetInt()
        {
            int res;
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                //throw new ValidationException("Int value is incorrect.");
                Console.Write("Enter correсt value: ");
            }

            return res;
        }
        public static double GetDouble()
        {
            double res;
            while (!double.TryParse(Console.ReadLine(), out res))
            {
                //throw new ValidationException("Double value is incorrect.");
                Console.Write("Enter correсt value: ");
            }

            return res;
        }
        public static DateTime GetDate()
        {
            DateTime res;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out res))
            {
                //throw new ValidationException("Date is incorrect.");
                Console.Write("Enter correсt date: ");
            }
            return res;
        }
        public static string GetString()
        {
            string res = Console.ReadLine();
            return res;
        }
    
    }
    
}
