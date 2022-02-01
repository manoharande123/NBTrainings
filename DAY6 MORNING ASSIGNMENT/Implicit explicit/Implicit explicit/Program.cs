using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_explicit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Implicit Casting
            int a = 15;
            long b = a;
            Console.WriteLine(b);

            //Explicit Casting
            long c = 20;
            int d = (int)c;


            Console.WriteLine(d);
            Console.ReadLine();
        }
    }

}
    