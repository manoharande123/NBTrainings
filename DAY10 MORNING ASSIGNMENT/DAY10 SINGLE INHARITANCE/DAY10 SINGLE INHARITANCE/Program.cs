using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_SINGLE_INHARITANCE
{
    class Algebra
    {
        /// <summary>
        /// This method is used for Addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
      
    }
    class substract :Algebra
    {
        /// <summary>
        /// This is used for subtraction
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Sub(int a , int b)
        {
            return a - b;
        }
      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            substract obj = new substract();
            Console.WriteLine(obj.Add(5, 5));
            Console.WriteLine(obj.Sub(4, 2));
            Console.ReadLine();



        }
    }
}
