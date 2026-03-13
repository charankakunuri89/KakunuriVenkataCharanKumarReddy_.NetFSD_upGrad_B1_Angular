using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Concepts_using_HealthCare_Domain
{
    internal class Nurse
    {

        public int NurseId { get; set; }

        public string NurseName { get; set; }

        public string Department { get; set; }

        static void Main(string[] args)
        {
            Nurse nurse = new Nurse();
            nurse.NurseId = 101;
            Console.WriteLine("Nurse ID: " + nurse.NurseId);
            nurse.NurseName = "Jayamma";
            Console.WriteLine("Nurse Name: " + nurse.NurseName);
            nurse.Department = "ICU";
            Console.WriteLine("Nurse Department: " + nurse.Department);

        }
    }
}
