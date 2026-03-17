using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.HealthCare_System
{
    internal class main
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor(101, "Dr.Charan", 30000, 12000);
            Nurse nurse = new Nurse(201, "Anitha", 15000, 3000);
            LabTechnician lab = new LabTechnician(301, "Sai", 10000, 2000);

            Console.WriteLine("Doctor Salary: " + doctor.CalculateSalary());
            Console.WriteLine("Nurse Salary: " + nurse.CalculateSalary());
            Console.WriteLine("Lab Technician: " + lab.CalculateSalary());

        }
    }
}
