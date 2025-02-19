using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Practices._04_02_2025
{
    class Vehicle
    {
        private static double RegistrationFee = 5000;
        public string OwnerName;
        public string VehicleType;
        public readonly string RegistrationNumber;

        public Vehicle(string ownerName, string vehicleType, string registrationNumber)
        {
            this.OwnerName = ownerName;
            this.VehicleType = vehicleType;
            this.RegistrationNumber = registrationNumber;
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }

        public void DisplayVehicleDetails()
        {
            if (this is Vehicle)
            {
                Console.WriteLine($"Owner: {OwnerName}, Type: {VehicleType}, Reg No: {RegistrationNumber}, Fee: {RegistrationFee}");
            }
        }
    }

    class VehicleRegistration
    {
        static void Main()
        {
            Vehicle v1 = new Vehicle("Kashish", "Car", "ABC123");
            Vehicle v2 = new Vehicle("Asihwarya", "Bike", "XYZ456");

            v1.DisplayVehicleDetails();
            v2.DisplayVehicleDetails();

            Vehicle.UpdateRegistrationFee(5500);
            Console.WriteLine("\nAfter Updating Registration Fee:");
            v1.DisplayVehicleDetails();
            v2.DisplayVehicleDetails();
        }
    }

}
