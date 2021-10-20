using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            s.SpeedUp();
            Console.WriteLine(s.Describe());

            Truck t = new Truck(45, 500);
            Console.WriteLine(t.Describe());

            Bicycle b = new Bicycle(10);
            Console.WriteLine(b.Describe());

            Console.ReadKey();
        }
    }
}
