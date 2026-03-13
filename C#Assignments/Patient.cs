using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Concepts_using_HealthCare_Domain
{
    internal class Patient
    {
        int PatientId;
        string PatientName;
        byte Age;
        string Disease;
        public Patient(int patientId, string patientName, byte age, string disease)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Disease = disease;
        }

        public void display()
        {
            Console.WriteLine("Patient Id: " + PatientId);
            Console.WriteLine("Patient Name: " + PatientName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
        }

        static void Main(string[] args)
        {
            Patient patient = new Patient(101, "Ravi Kumar", 45, "Diabetes");
            patient.display();
        }
    }
}
