using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY11_PROJECT_11
{
    class Mathematics
    {
        public static int Add(int a , int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Product(int a, int b)
        {
            return a * b;
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics math = new Mathematics();
            Console.WriteLine($"Addiion={Mathematics.Add(12,6)}");
            Console.WriteLine($"Difference= {Mathematics.Sub(10, 4)}");
            Console.WriteLine($"Product= {Mathematics.Product(5, 4)}");
            Console.ReadLine();


        }
    }
}
