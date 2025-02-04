using System;

class Vehicle
{
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }
    public static double RegistrationFee = 500.0;

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner: {OwnerName}, Vehicle Type: {VehicleType}, Registration Fee: {RegistrationFee}");
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
    }
}

class VehicleTest
{
    // static void Main()
    // {
        // // Create instances of Vehicle
        // Vehicle vehicle1 = new Vehicle { OwnerName = "John Doe", VehicleType = "Car" };
        // Vehicle vehicle2 = new Vehicle { OwnerName = "Jane Smith", VehicleType = "Truck" };

        // // Display vehicle details
        // vehicle1.DisplayVehicleDetails();
        // vehicle2.DisplayVehicleDetails();

        // // Update Registration Fee
        // Vehicle.UpdateRegistrationFee(600.0);

        // // Display updated vehicle details
        // Console.WriteLine("\nAfter updating the Registration Fee:");
        // vehicle1.DisplayVehicleDetails();
        // vehicle2.DisplayVehicleDetails();
    // }
}
