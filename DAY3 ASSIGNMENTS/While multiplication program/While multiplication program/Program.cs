using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_multiplication_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input, i = 1;
            Console.WriteLine("enter number");
            input = Convert.ToInt32(Console.ReadLine());
            while (i <= 10)
            {
                Console.WriteLine("{0}x{1}={2}", input, i, input * i);
                i++;

            }
            Console.ReadLine();
               
        }
    }
}
