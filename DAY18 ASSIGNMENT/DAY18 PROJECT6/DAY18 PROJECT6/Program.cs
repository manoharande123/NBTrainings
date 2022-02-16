using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsLibrary;

namespace DAY18_PROJECT6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Algebra.Factorial(5));
            Console.WriteLine(Algebra.Factorial(0));
            Console.WriteLine( Algebra.Factorial(8));
            Console.WriteLine(Algebra.Factorial(-5));
            Algebra.Palindrome(121);
           

            Console.ReadLine();
        }
    }
}
