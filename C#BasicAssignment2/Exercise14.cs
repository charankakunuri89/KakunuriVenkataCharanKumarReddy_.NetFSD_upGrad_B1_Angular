using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers to find smallest among them");
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int small = arr[0];
            foreach (int i in arr)
            {
                if (small > i) small = i;
            }
            Console.WriteLine($" smallest of five number accepted from user is : {small}");
        }
    }
}
