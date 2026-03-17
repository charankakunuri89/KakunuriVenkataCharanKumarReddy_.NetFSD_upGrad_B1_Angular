using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Banking_System
{
    internal class SavingsAccount : Account
    {
        public new void CalculateInterest()
        {
            Console.WriteLine("Savings Account Interest");
        }
    }
}
