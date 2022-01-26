using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Facatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input, product = 1, i;
            //user input
            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());

            //logic
            for(i=1;i<=input;i++)
            {
                product = product * i;

            }

            //output 
            Console.WriteLine(product);
            Console.ReadLine();

        }
    }
}
