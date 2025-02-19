using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Base
{
    public virtual void Display(string message) => Console.WriteLine("Base: " + message);
}

class Derived : Base
{
    public override void Display(string message) => Console.WriteLine("Derived: " + message);

    public void Display(int number) => Console.WriteLine("Number: " + number);
}

class Program
{
    static void Main()
    {
        Derived obj = new Derived();
        obj.Display("Hello");
        obj.Display(10);
    }
}
