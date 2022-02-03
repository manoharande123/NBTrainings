using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_search_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array declaratiion and initialisation

            int[] data = new int[] { 3, 8, 10, 15, 25, 4, 7, 10 };
            int input;

            //Reading user input
            Console.WriteLine("Enter number to search:");
             input = Convert.ToInt32(Console.ReadLine());

            //forloop
            for (int i = 0; i < data.Length; i++)
            {
                if (input==data[i])
                {
                    Console.WriteLine($"The number {input},is in index{i}, at position{i + 1}");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("The number is not found");// if it is not found
            Console.WriteLine("Enter the correct number:");
            Console.ReadLine();
        }

    }
}

 