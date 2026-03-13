using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise5
    {
        static void Main(string[] args)
        {
            int evenCount = 0, oddCount = 0;
            Console.WriteLine("How many number do you want to enter: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter number " + i + ":");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Total Even Numbers = " + evenCount);
            Console.WriteLine("Total Odd Numbers = " + oddCount);
        }
    }
}
