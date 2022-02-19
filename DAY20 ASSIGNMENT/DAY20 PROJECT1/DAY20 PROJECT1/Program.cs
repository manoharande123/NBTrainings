using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY20_PROJECT1
{
    public delegate void MyCaller(int a, int b);
    internal class Program
    {
        public static void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        static void Main(string[] args)
        {
            MyCaller mc = new MyCaller(Add);
            mc += Sub;
            mc += Mul;

            //2,4
            
            mc(2, 4);

            //3,2
            mc(6, 2);

            //10,5
            mc(10, 5);



            Console.ReadLine();


        }
    }
}
