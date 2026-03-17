using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.E_Commerce_Order_System
{
    internal class Order
    {
        public int OrderId;
        public double OrderAmount;
       
        public Order (int orderId, double orderAmount)
        {
            OrderId = orderId;
            OrderAmount = orderAmount;
        }

        public virtual double CalculateShippingCost()
        {
            return 50;
        }
    }
}
