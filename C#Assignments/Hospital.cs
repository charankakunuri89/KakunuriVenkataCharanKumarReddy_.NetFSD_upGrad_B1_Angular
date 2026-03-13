using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Concepts_using_HealthCare_Domain
{
    internal class Hospital
    {
        static string HospitalName;
        static string HospitalAddress;
        string PatientName;

        static void Main(string[] args)
        {
            Hospital.HospitalName = "Nature Cure Hospital";
            Hospital.HospitalAddress = "Nature Cure Near MMTS Railway Station, Hyderabad";

            Hospital pat1 = new Hospital();
            Hospital pat2 = new Hospital();
            Hospital pat3 = new Hospital();

            pat1.PatientName = "sadha";
            pat2.PatientName = "sumanth";
            pat3.PatientName = "Aditya";

            Console.WriteLine(HospitalName + "-" + HospitalAddress);
            Console.WriteLine("Patient: " + pat1.PatientName);
            Console.WriteLine("Patient: " + pat2.PatientName);
            Console.WriteLine("Patient: " + pat3.PatientName);
        }
    }
}
