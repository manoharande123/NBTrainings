using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManoharLibrary;
using PublicLibrary;

namespace ClintApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mathematics.Factorial(6));
            Console.WriteLine(Mathematics.Add(5, 5));
            Console.WriteLine(Mathematics.Mul(2, 3));
            Console.WriteLine(Physics.FinalVelocity(2,3,4));
            
            Console.ReadLine();
        }
    }
}
