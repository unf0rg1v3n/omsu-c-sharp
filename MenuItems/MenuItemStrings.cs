using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab
{
    internal class MenuItemStrings : MenuItemCore
    {
        string str1, str2;
        public override string GetInfo()
        {
            return "Strings";
        }
        public override void Execute()
        {
            Init();

            Console.WriteLine("\nResults:");

            Console.WriteLine("\nStrings are equal: " + str1.Equals(str2));
            
            string formattedStr1 = Format(str1);
            string formattedStr2 = Format(str2);

            Console.WriteLine("\nStrings are equal after formatting: " + formattedStr1.Equals(formattedStr2));

            try
            {
                ReverseCompare(str1, str2);
                Console.WriteLine("\nOne string is the invert of another");
            } catch (ValidationException) 
            {
                Console.WriteLine("\nOne string is not the invert of another");
            }

            Console.Write($"\n{str1} - ");
            CheckString(str1);

            Console.Write($"\n{str2} - ");
            CheckString(str2);

        }
        void Init()
        {
            Console.Write("Enter first string: ");
            this.str1 = IOUtils.GetString();
            Console.Write("Enter second string: ");
            this.str2 = IOUtils.GetString();
        }
        void CheckString(string str)
        {
            try
            {
                IsPhoneNumber(str);
                Console.WriteLine("string is a phone number.");
                return;
            }
            catch (ValidationException) { }
            try
            {
                IsEmail(str);
                Console.WriteLine("string is an email.");
                return;
            }
            catch (ValidationException) { }
            try
            {
                IsIP(str);
                Console.WriteLine("string is an IP address.");
                return;
            }
            catch (ValidationException) { }
            Console.WriteLine("string is not an email/IP/phone number.");
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
            if (Regex.IsMatch(str, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$")) 
            { 
                return true; 
            }
            throw new ValidationException("String is not a phone nubmer.");
        }
        static bool IsEmail(string str)
        {
            if (Regex.IsMatch(str, "[^@ \\t\\r\\n]+@[^@ \\t\\r\\n]+\\.[^@ \\t\\r\\n]+"))
            {
                return true;
            }
            throw new ValidationException("String is not an email.");
        }
        static bool IsIP(string str)
        {
            if (Regex.IsMatch(str, @"(\b25[0-5]|\b2[0-4][0-9]|\b[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}"))
            {
                return true;
            }
            throw new ValidationException("String is not an IP address.");
        }
        static bool ReverseCompare(string str1, string str2)
        {
            string newStr = new string (str2.Reverse().ToArray());
            if (str1.Equals(newStr)) 
            {
                return true;
            }
            throw new ValidationException("Strings are not equal.");
        }
    }
}
