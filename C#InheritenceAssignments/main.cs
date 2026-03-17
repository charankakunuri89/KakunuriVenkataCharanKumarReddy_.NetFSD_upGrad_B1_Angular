using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Banking_System
{
    internal class main
    {
        static void Main(string[] args)
        {
            Account acc = new SavingsAccount();
            acc.CalculateInterest();

            Account acc1 = new CurrentAccount();
            acc1.CalculateInterest();

            SavingsAccount sacc = new SavingsAccount();
            sacc.CalculateInterest();

            CurrentAccount cacc = new CurrentAccount();
            cacc.CalculateInterest();
        }
    }
}
