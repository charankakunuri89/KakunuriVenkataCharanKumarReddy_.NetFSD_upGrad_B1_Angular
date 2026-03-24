using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment.Assignment2
{
    internal class main
    {
        static void Main(string[] args)
        {
            SalesCalculator salesCalculator = new SalesCalculator();

            Console.WriteLine("Daily sales: Rs." + salesCalculator.GetDailySales());
            Console.WriteLine("Monthly Sales: Rs." + salesCalculator.GetMonthlySales());
            Console.WriteLine("Annual Sales: Rs." + salesCalculator.GetAnnualSales()); 
        }
    }
}
