using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Concepts_using_HealthCare_Domain
{
    internal class PatientRecord
    {
        int PatientId;
        string PatientName;
        byte Age;
        string Disease;
        static string HospitalName;

        public PatientRecord(int patientId, string patientName, byte age, string disease)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Disease = disease;
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine("Patient Id: " + PatientId);
            Console.WriteLine("Name: " + PatientName);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
            Console.WriteLine();
        }
        

        static void Main(string[] args)
        {
            PatientRecord.HospitalName = "Apollo Hospital";
            PatientRecord patientRecord = new PatientRecord(101, "Ravi", 40, "Fever");
            PatientRecord patientRecord1 = new PatientRecord(102, "Sumanth", 22, "Ulcers");
            PatientRecord patientRecord2 = new PatientRecord(111, "Ganesh", 21, "Cough");
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine();
            patientRecord.DisplayPatientRecord();
            patientRecord1.DisplayPatientRecord();
            patientRecord2.DisplayPatientRecord();
        }
    }
}
