using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Engine
{
    public void Start() => Console.WriteLine("Engine started.");
}

class Car
{
    private Engine _engine = new Engine();

    public void StartCar()
    {
        _engine.Start();
        Console.WriteLine("Car is moving.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.StartCar();
    }
}
