using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Furniture_System
{
    internal class main
    {

            static void Main(string[] args)
            {
                Console.WriteLine("Select Furniture Type");
                Console.WriteLine("1. Chair");
                Console.WriteLine("2. Cot");

                int choice = Convert.ToInt32(Console.ReadLine());

                Furniture furniture;

                if (choice == 1)
                    furniture = new Chair();
                else
                    furniture = new Cot();

                furniture.GetData();

                Console.WriteLine("\n----- Furniture Details -----");
                furniture.ShowData();
            }
        
    }
}
