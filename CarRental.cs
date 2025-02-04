using System;

class CarRental
{
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    private const double RatePerDay = 50.0; // Fixed rate per day

    // Default Constructor
    public CarRental()
    {
        CustomerName = "Unknown";
        CarModel = "Unknown";
        RentalDays = 1;
    }

    // Parameterized Constructor
    public CarRental(string customerName, string carModel, int rentalDays)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
    }

    // Method to Calculate Total Cost
    public double CalculateTotalCost()
    {
        return RentalDays * RatePerDay;
    }

    // Display Rental Details
    public void DisplayRentalDetails()
    {
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Car Model: {CarModel}");
        Console.WriteLine($"Rental Days: {RentalDays}");
        Console.WriteLine($"Total Cost: ${CalculateTotalCost()}");
    }
}

// Main Program to Test CarRental
class CarRentalProgram
{
    // static void Main()
    // {
        // // Using Default Constructor
        // CarRental rental1 = new CarRental();
        // Console.WriteLine("Default Car Rental:");
        // rental1.DisplayRentalDetails();

        // // Using Parameterized Constructor
        // CarRental rental2 = new CarRental("Alice Johnson", "Toyota Camry", 5);
        // Console.WriteLine("\nParameterized Car Rental:");
        // rental2.DisplayRentalDetails();
    // }
}
