using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Practices._04_02_2025
{
    using System;

    class Product
    {
        private static double Discount = 10; // Shared across all products
        public string ProductName;
        public double Price;
        public int Quantity;
        public readonly string ProductID;

        public Product(string productName, double price, int quantity, string productID)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
            this.ProductID = productID;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }

        public void DisplayProductDetails()
        {
            if (this is Product)
            {
                Console.WriteLine($"Product: {ProductName}, Price: {Price}, Quantity: {Quantity}, Discount: {Discount}%");
            }
        }
    }

    class ShoppingCartSystem
    {
        static void Main()
        {
            Product p1 = new Product("Laptop", 800, 1, "P001");
            Product p2 = new Product("Phone", 500, 2, "P002");

            p1.DisplayProductDetails();
            p2.DisplayProductDetails();

            Product.UpdateDiscount(15);
            Console.WriteLine("\nAfter Updating Discount:");
            p1.DisplayProductDetails();
            p2.DisplayProductDetails();
        }
    }

}
