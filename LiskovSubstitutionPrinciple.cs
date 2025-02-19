using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Bird
{
    public abstract void Fly();
}

class Sparrow : Bird
{
    public override void Fly() => Console.WriteLine("Sparrow is flying.");
}

class Program
{
    static void Main()
    {
        Bird myBird = new Sparrow();
        myBird.Fly();
    }
}
