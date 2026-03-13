using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise7
    {
        static void Main(string[] args)
        {
            int productNumber, quantity;
            double price = 0, totalPrice;

            Console.WriteLine("Enter product number (1-3): ");
            productNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter quantity sold: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            switch (productNumber)
            {

                case 1:
                    price = 22.5;
                    break;
                case 2:
                    price = 44.50;
                    break;
                case 3:
                    price = 9.98;
                    break;
                default:
                    Console.WriteLine("Invalid product number");
                    return;
            }
            totalPrice = price * quantity;
            Console.WriteLine("Total Price = " + totalPrice);
        }
    }
}
