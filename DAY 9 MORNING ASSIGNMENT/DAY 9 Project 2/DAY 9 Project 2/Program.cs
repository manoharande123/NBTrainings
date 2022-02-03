
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Project2
{     //***********************\\
      //Author:ANDE MANOHAR
      //Purpose:Write C# program to read two numbers from user and print
      //A)Sum of two numbers
      //B)Difference of two numbers
      //C)Product of two numbers
      //d)Division of two numbers
      

    class MathTask
    {
        private int a;
        private int b;
        // <summary>
        // This method read input From user
        // </summary>
        public void ReadInput()
        {
            Console.WriteLine("Enter fisrt number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number:");
            b = Convert.ToInt32(Console.ReadLine());
        }// <summary>
         // This method Add Two numbers
         // </summary>
         // <returns></returns>
        public int AddNumbers()
        {
            return a + b;
        }
        // <summary>
        // this method is for multiplication
        // </summary>
        // <returns></returns>
        public int Product()
        {
            return a * b;
        }
        // <summary>
        // this method is substraction
        // </summary>
        // <returns></returns>
        public int Substract()
        {
            return a - b;
        }
        // <summary>
        // this method is for division
        // </summary>
       // <returns></returns>
        public int Division()
        {
            return b / a;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MathTask mt = new MathTask();
            mt.ReadInput();
            Console.WriteLine(mt.AddNumbers());
            Console.WriteLine(mt.Product());
            Console.WriteLine(mt.Substract());
            Console.WriteLine(mt.Division());
            Console.ReadLine();
        }
    }
}
