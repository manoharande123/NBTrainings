using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Factors_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declarartion
            int input, i;
            Console.WriteLine("Enter any number");
            input = Convert.ToInt32(Console.ReadLine());


            //logic
            for (i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
                

        }
    }
}
