using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Furniture_System
{
    internal class Cot : Furniture
    {
        public string CotType;
        public string MaterialType;
        public string Capacity;
        public double Rate;

        public override void GetData()
        {
            FurnitureType = "Cot";

            base.GetData();

            Console.WriteLine("Enter Cot Type (Wood/Steel):");
            CotType = Console.ReadLine();

            Console.WriteLine("Enter Material Type:");
            MaterialType = Console.ReadLine();

            Console.WriteLine("Enter Capacity (Single/Double):");
            Capacity = Console.ReadLine();

            Console.WriteLine("Enter Rate:");
            Rate = Convert.ToDouble(Console.ReadLine());

            TotalAmt = Rate * Qty;
        }

        public override void ShowData()
        {
            base.ShowData();

            Console.WriteLine("Cot Type: " + CotType);
            Console.WriteLine("Material Type: " + MaterialType);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Rate: " + Rate);
        }
    }
}
