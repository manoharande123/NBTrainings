using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_power1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fn, sn, sum = 0;

            int p = 1;

            fn = 60;

            Console.WriteLine("Enter first number:");
            fn = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second number:");
            sn = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= sn; i++)

                p = p * fn;

            Console.WriteLine("power =" + p);




            
            Console.ReadLine();







        }
    }
}
