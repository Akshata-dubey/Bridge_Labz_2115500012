using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IEngine
{
    void Start();
}

interface IGearbox
{
    void ChangeGear();
}

class Cares : IEngine, IGearbox
{
    public void Start() => Console.WriteLine("Engine started.");
    public void ChangeGear() => Console.WriteLine("Gear changed.");
}

class Program
{
    static void Main()
    {
        Cares myCar = new Cares ();
        myCar.Start();
        myCar.ChangeGear();
    }
}
