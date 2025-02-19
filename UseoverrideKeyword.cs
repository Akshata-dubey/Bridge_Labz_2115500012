using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Parent
{
    public virtual void Greet() => Console.WriteLine("Hello from Parent");
}

class Child : Parent
{
    public override void Greet() => Console.WriteLine("Hello from Child");
}

class Program
{
    static void Main()
    {
        Child child = new Child();
        child.Greet();
    }
}
