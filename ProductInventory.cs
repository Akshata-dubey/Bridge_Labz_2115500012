using System;

class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public static int TotalProducts = 0; // Shared across all instances

    // Default Constructor
    public Product()
    {
        ProductName = "Unknown";
        Price = 0.0;
        TotalProducts++;
    }

    // Parameterized Constructor
    public Product(string name, double price)
    {
        ProductName = name;
        Price = price;
        TotalProducts++;
    }

    // Instance Method to Display Product Details
    public void DisplayProductDetails()
    {
        Console.WriteLine($"Product: {ProductName}, Price: ${Price}");
    }

    // Static Method to Display Total Products Created
    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"Total Products Created: {TotalProducts}");
    }
}

// Main Program to Test Product Class
class ProductProgram
{
    // static void Main()
    // {
        // // Creating Products
        // Product product1 = new Product("Laptop", 899.99);
        // Product product2 = new Product("Smartphone", 499.99);
        // Product product3 = new Product(); // Default values

        // // Displaying Product Details
        // Console.WriteLine("Product List:");
        // product1.DisplayProductDetails();
        // product2.DisplayProductDetails();
        // product3.DisplayProductDetails();

        // // Displaying Total Products
        // Product.DisplayTotalProducts();
    // }
}
