using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_4_read_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int[] data = new int[5];

            // user input
            for(int i = 0; i<data.Length;i++)
            {
                Console.WriteLine("Enter Number");
                data[i] = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine("The numbers enetered are:");
            foreach (int d in data)
                Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
