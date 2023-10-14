using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab
{
    internal class MenuItemStrings : MenuItemCore
    {
        public override string GetInfo()
        {
            return "Strings";
        }
        public override void Execute()
        {
            string str1, str2;
            Console.Write("Enter first string: ");
            str1 = IOUtils.GetString();
            Console.Write("Enter second string: ");
            str2 = IOUtils.GetString();

            Console.WriteLine("\nRsults:");
            Console.WriteLine("\nStrings are equal: " + str1.Equals(str2));
            str1 = Format(str1);
            str2 = Format(str2);
            Console.WriteLine("\nFormatted strings are equal: " + str1.Equals(str2));
            Console.WriteLine("\nString equivalents in reverse order: " + ReverseCompare(str1, str2));
            Console.WriteLine("\nString is IP adress:" +
                $"\n\t{str1} - {IsIP(str1)}" +
                $"\n\t{str2} - {IsIP(str2)}");
            Console.WriteLine("\nString is email adress:" +
                $"\n\t{str1} - {IsEmail(str1)}" +
                $"\n\t{str2} - {IsEmail(str2)}");
            Console.WriteLine("\nString is phone number:" +
                $"\n\t{str1} - {IsPhoneNumber(str1)}" +
                $"\n\t{str2} - {IsPhoneNumber(str2)}");
        }
        static string Format(string str)
        {
            str = str.Trim();
            str = str.ToLower();
            str = str.Replace("  ", " ");
            return str;
        }
        static bool IsPhoneNumber(string str)
        {
            return Regex.IsMatch(str, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
        }
        static bool IsEmail(string str)
        {
            return Regex.IsMatch(str, "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+");
        }
        static bool IsIP(string str)
        {
            return Regex.IsMatch(str, @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}");
        }
        static bool ReverseCompare(string str1, string str2)
        {
            str1 = str1.Reverse().ToString();
            return str1.Equals(str2);
        }
    }
}
