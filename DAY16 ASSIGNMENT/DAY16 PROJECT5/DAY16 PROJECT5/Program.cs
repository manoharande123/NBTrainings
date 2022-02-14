using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManoharLibrary1;


namespace DAY16_PROJECT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Chemistry.GetWater());
            Console.WriteLine(Chemistry.GetBenzene());
            Console.WriteLine(Chemistry.GetMethene());
            Console.WriteLine(Mathematics.Add(5,7));
            Console.WriteLine(Mathematics.Sub(10,5));
            Console.WriteLine(Physics.GetVelocity(3,2,3));

            Console.ReadLine();
        }
    }
}
