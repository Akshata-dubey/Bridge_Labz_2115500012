using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BaseClass
{
    public virtual void ShowMessage() => Console.WriteLine("BaseClass Message");
}

class DerivedClass : BaseClass
{
    public sealed override void ShowMessage() => Console.WriteLine("DerivedClass Message");
}

class Program
{
    static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.ShowMessage();
    }
}
