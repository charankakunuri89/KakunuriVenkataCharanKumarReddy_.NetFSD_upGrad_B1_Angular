using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.E_Commerce_Order_System
{
    internal class main
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            orders.Add(new StandardOrder(101, 1231));
            orders.Add(new ExpressOrder(121, 1432));
            orders.Add(new InternationalOrder(331, 13456));

            foreach (Order o in orders)
            {
                Console.WriteLine($"Order Id is: {o.OrderId}");
                Console.WriteLine($"Order Amount is: {o.OrderAmount}");
                Console.WriteLine($"Order Shipping Cost is : {o.CalculateShippingCost()}");
                Console.WriteLine();
            }
        }
    }
}
