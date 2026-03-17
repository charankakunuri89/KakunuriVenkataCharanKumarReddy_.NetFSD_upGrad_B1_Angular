using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Banking_System
{
    internal class CurrentAccount : Account
    {
        public new void CalculateInterest()
        {
            Console.WriteLine("Current Account Interest");
        }
    }
}
