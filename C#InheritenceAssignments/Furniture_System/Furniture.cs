using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Furniture_System
{
    internal class Furniture
    {
        public int OrderId;
        public string OrderDate;
        public string FurnitureType;
        public int Qty;
        public double TotalAmt;
        public string PaymentMode;

        public virtual void GetData()
        {
            Console.WriteLine("Enter Order ID:");
            OrderId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Order Date:");
            OrderDate = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Payment Mode (Credit/Debit Card)");
            PaymentMode = Console.ReadLine();
        }

        public virtual void ShowData()
        {
            Console.WriteLine("Order ID: " + OrderId);
            Console.WriteLine("Order Date: " + OrderDate);
            Console.WriteLine("Furniture Type: " + FurnitureType);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Payment Mode: " + PaymentMode);
            Console.WriteLine("Total AMount: " + TotalAmt);
        }

    }
}
