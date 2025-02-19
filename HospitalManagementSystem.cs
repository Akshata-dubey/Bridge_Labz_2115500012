using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Practices._04_02_2025
{
    class Patient
    {
        private static int TotalPatients = 0;
        private static string HospitalName = "City Hospital";
        public string Name;
        public int Age;
        public string Ailment;
        public readonly int PatientID;

        public Patient(string name, int age, string ailment, int patientID)
        {
            this.Name = name;
            this.Age = age;
            this.Ailment = ailment;
            this.PatientID = patientID;
            TotalPatients++;
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total Patients Admitted: {TotalPatients}");
        }

        public void DisplayPatientDetails()
        {
            if (this is Patient)
            {
                Console.WriteLine($"{HospitalName} | Name: {Name}, Age: {Age}, Ailment: {Ailment}, Patient ID: {PatientID}");
            }
        }
    }

    class HospitalManagement
    {
        static void Main()
        {
            Patient p1 = new Patient("Humpty", 13, "Fever", 101);
            Patient p2 = new Patient("Dumpty", 15, "Diabetes", 102);

            p1.DisplayPatientDetails();
            p2.DisplayPatientDetails();

            Patient.GetTotalPatients();
        }
    }

}
