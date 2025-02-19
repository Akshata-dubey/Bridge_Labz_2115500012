using System;
using System.Collections.Generic;

class Shopper
{
    public string Name { get; set; }
    public List<Purchase> Purchases { get; set; }

    // Constructor 
    public Shopper(string name)
    {
        Name = name;
        Purchases = new List<Purchase>();
    }

    // Method to place an order
    public void MakePurchase(Purchase purchase)
    {
        Purchases.Add(purchase);
    }
}

class Purchase
{
    public List<Item> Items { get; set; }

    // Constructor 
    public Purchase()
    {
        Items = new List<Item>();
    }

    // Method to add a product to the purchase
    public void AddItem(Item item)
    {
        Items.Add(item);
    }
}

class Item
{
    public string Name { get; set; }

    // Constructor 
    public Item(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        var shopper = new Shopper("Alice");
        var item1 = new Item("Laptop");
        var item2 = new Item("Smartphone");

        var purchase = new Purchase();
        purchase.AddItem(item1);
        purchase.AddItem(item2);

        shopper.MakePurchase(purchase);

        // Displaying the shopper's purchase with items
        Console.WriteLine($"{shopper.Name} made a purchase with the following items:");
        foreach (var item in purchase.Items)
        {
            Console.WriteLine(item.Name);
        }
    }
}
