using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Array_initialisation_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int sum = 0, a;
            int[] data = new int[] { 2, 3, 4, 5, 6 };
            foreach(int d in data)

            {
                sum += d;

            }
            a = sum / 5;
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The average is" + a);
            Console.ReadLine();


                    
                    
        }
    }
}
