using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.E_Commerce_Order_System
{
    internal class ExpressOrder : Order
    {
        public ExpressOrder(int orderId, double orderAmount) : base(orderId, orderAmount)
        {
        }

        public override double CalculateShippingCost()
        {
            return 100;
        }
    }
}
