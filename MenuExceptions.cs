using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class ExitException : Exception
    {
        public ExitException() : base() { }
    }
    internal class MenuItemException : Exception
    {
        public MenuItemException() : base() { }
    }
    class ValidationException : Exception
    {
        public ValidationException(string Message) : base(Message) { }
    }
}
