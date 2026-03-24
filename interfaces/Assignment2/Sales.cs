using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment.Assignment2
{
    internal abstract class Sales
    {
        public int GetDailySales()
        {
            return 400;
        }

        public abstract int GetMonthlySales();
    }
}
