using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Furniture_System
{
    internal class Chair : Furniture
    {
        public string ChairType;
        public string Purpose;
        public string MaterialType;
        public double Rate;

        public override void GetData()
        {
            FurnitureType = "Chair";

            base.GetData();

            Console.WriteLine("Enter Chair Type (Wood/Steel/Plastic): ");
            ChairType = Console.ReadLine();

            Console.WriteLine("Enter Purpose (Home/Office):");
            Purpose = Console.ReadLine();

            Console.WriteLine("Enter Material Type:");
            Console.WriteLine("Wood: Teak Wood / Rose Wood");
            Console.WriteLine("Steel: Gray Steel / Green Steel / Brown Steel");
            Console.WriteLine("Plastic: Green / Red / Blue / White");

            MaterialType = Console.ReadLine();

            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDouble(Console.ReadLine());

            TotalAmt = Rate * Qty;
        }

        public override void ShowData()
        {
            base.ShowData();

            Console.WriteLine("Chair Type: " + ChairType);
            Console.WriteLine("Purpose: " + Purpose);
            Console.WriteLine("Material Type: " + MaterialType);
            Console.WriteLine("Rate: " + Rate);
        }
    }
}
