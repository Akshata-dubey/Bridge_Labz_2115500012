using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Parents
{
    private int _age;
    public int Age
    {
        get => _age;
        set => _age = value;
    }
}

class Program
{
    static void Main()
    {
        Parents obj = new Parents { Age = 30 };
        Console.WriteLine($"Age: {obj.Age}");
    }
}
