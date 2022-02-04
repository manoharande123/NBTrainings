using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    class Algebra
    {
        /// <summary>
        /// This is for addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// This is used for addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        /// <summary>
        /// This is used for addition
        /// </summary
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Algebra m = new Algebra();
            Console.WriteLine("sum1is {0}", m.Add(5, 2));
            Console.WriteLine("sum2 is {0}", m.Add(3,5,2));
            Console.WriteLine("sum3 is {0}", m.Add(2,5,1,2));
            
            Console.ReadLine();
        }
    }
}
