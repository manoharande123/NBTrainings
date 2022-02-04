using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_multi_level_inharitance
{
    class Algebra
    {
       /// <summary>
       /// This method is used to find addition
       /// </summary>
       /// <param name="a"></param>
       /// <param name="b"></param>
       /// <returns></returns>
        public int Add(int a, int b )
        {
            return a + b;
        }
    }
    class Substract :Algebra
    {
        /// <summary>
        /// This is used to find substraction
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
    class product : Substract
    {
       /// <summary>
       /// his method is used for product
       /// </summary>
       /// <param name="a"></param>
       /// <param name="b"></param>
       /// <returns></returns>
        public int Multi(int a, int b)
        {
            return a * b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            product obj = new product();
            Console.WriteLine($"Add = {obj.Add(10, 5)}");
            Console.WriteLine($"Sub = {obj.Sub(10, 5)}");
            Console.WriteLine($"product = {obj.Multi(5, 5)}");

            Console.ReadLine();



        }
    }
}
