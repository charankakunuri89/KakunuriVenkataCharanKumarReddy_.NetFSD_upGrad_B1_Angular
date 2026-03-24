using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment.Assignment2
{
    internal class SalesCalculator : Sales, ISales
    {
        public override int GetMonthlySales()
        {
            int daily = GetDailySales();
            return daily * 30;
        }

        public int GetAnnualSales()
        {
            int monthly = GetMonthlySales();
            return monthly * 12;
        }
    }
}
