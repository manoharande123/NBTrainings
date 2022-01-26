using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sum__and_avg_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int sum = 0, avg;
            int[] data = new int[5];

            //user input
            for(int i =0;i<data.Length;i++)
            {
                Console.WriteLine("Enter number");
                data[i] = Convert.ToInt32(Console.ReadLine());




            }
            foreach(int d in data)
            {
                sum = sum + d;

            }
            avg = sum / data.Length;
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.ReadLine();

        }
    }
}
