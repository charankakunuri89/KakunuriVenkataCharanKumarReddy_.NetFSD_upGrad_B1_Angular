using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.E_Commerce_Order_System
{
    internal class InternationalOrder : Order
    {
        public InternationalOrder(int orderId, double orderAmount) : base(orderId, orderAmount)
        {

        }

        public override double CalculateShippingCost()
        {
            return 500;
        }
    }
}
