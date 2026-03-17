using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Vehicle_Management_System
{
   public sealed class ElectricCar : Car
    {
        public int BatteryCapacity;

        public void ChargeBattery(){

            Console.WriteLine("Battery is charging...");
        }
    }
}
