using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Vehicle_Management_System
{
    internal class main
    {
        static void Main(string[] args)
        {
            ElectricCar electricCar = new ElectricCar();
            electricCar.VehicleNumber = 1432;
            electricCar.Brand = "Tesla";
            electricCar.FuelType = "Electric";
            electricCar.BatteryCapacity = 100;

            electricCar.StartVehicle();
            electricCar.ChargeBattery();
        }
    }
}
