using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Sum__of_n_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int input, sum = 0, i;

            //user input
            Console.WriteLine("enter any number");
            input = Convert.ToInt32(Console.ReadLine());

            //logic
            for(i=1;i<=input;i++)
            {
                sum = sum + i;

            }

            //print output
            Console.WriteLine(sum);
            Console.ReadLine();


        }
    }
}
