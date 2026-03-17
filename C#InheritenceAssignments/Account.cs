using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Banking_System
{
    internal class Account
    {
        public int AccountNumber;
        public double Balance;

        public void CalculateInterest()
        {
            Console.WriteLine("Base Account Interest Calculation");
        }
    }
}
