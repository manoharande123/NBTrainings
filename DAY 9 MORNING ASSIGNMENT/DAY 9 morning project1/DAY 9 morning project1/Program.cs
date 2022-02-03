using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_9_morning_project1
{
    //*********************\\
    //Author: MANOHAR ANDE 
    //Purpose:To write a C# program to read input from user and print
    //Factorial of a number
    //Factors of a number
    //Check if it is Prime or not
    //*********************\\
    class MathsOperations
    {
        private int input;
        /// <summary>
        /// This method will read input
        /// </summary>
        public void ReadInput()
        {
            Console.WriteLine("Enter input");
            input = Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// this method will find factorial
        /// </summary>
        public void Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
        /// <summary>
        /// This method will find factors
        /// </summary>
        public void PrintFactors()
        {
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.WriteLine(i);
            }
        }
        /// <summary>
        /// This method will find a number as prime or not
        /// </summary>
        /// <returns></returns>
        public bool IsPrime()
        {
            int count = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsOperations obj = new MathsOperations();
            obj.ReadInput();
            obj.Factorial();
            obj.PrintFactors();
            if (obj.IsPrime())
                Console.WriteLine("The input number is Prime");
            else
                Console.WriteLine("The input number is not prime");


            Console.ReadLine();
        }
    }
}