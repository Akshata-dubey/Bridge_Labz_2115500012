using System;

class HotelBooking
{
    public string GuestName { get; set; }
    public string RoomType { get; set; }
    public int Nights { get; set; }

    // Default Constructor
    public HotelBooking() : this("Guest", "Standard", 1) { }

    // Parameterized Constructor
    public HotelBooking(string guestName, string roomType, int nights)
    {
        GuestName = guestName;
        RoomType = roomType;
        Nights = nights;
    }

    // Copy Constructor
    public HotelBooking(HotelBooking other)
    {
        GuestName = other.GuestName;
        RoomType = other.RoomType;
        Nights = other.Nights;
    }

    // Display Booking Details
    public void DisplayBooking()
    {
        Console.WriteLine($"Guest: {GuestName}, Room: {RoomType}, Nights: {Nights}");
    }
}

// Main Program to Test HotelBooking Class
class Hotel
{
    // static void Main()
    // {
        // // Using Default Constructor
        // HotelBooking booking1 = new HotelBooking();
        // Console.WriteLine("Default Booking:");
        // booking1.DisplayBooking();

        // // Using Parameterized Constructor
        // HotelBooking booking2 = new HotelBooking("Alice", "Deluxe", 3);
        // Console.WriteLine("\nParameterized Booking:");
        // booking2.DisplayBooking();

        // // Using Copy Constructor
        // HotelBooking booking3 = new HotelBooking(booking2);
        // Console.WriteLine("\nCopied Booking:");
        // booking3.DisplayBooking();
    // }
}
