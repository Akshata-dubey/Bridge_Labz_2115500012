using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy Constructor
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }

    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// Rename Program class to avoid conflicts
class PersonProgram
{
    // static void Main()
    // {
        // // Creating an original person object
        // Person person1 = new Person("Alice", 25);
        // Console.WriteLine("Original Person:");
        // person1.DisplayPerson();

        // // Creating a copy using the copy constructor
        // Person person2 = new Person(person1);
        // Console.WriteLine("Copied Person:");
        // person2.DisplayPerson();
    // }
}
