using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY20_PROJECT3
{
    internal class Program
    {
        public static void Out(out int a)
        {
            a = 10;
        }
        public static void Ref(ref int b)
        {
            b = 8;
        }
        static void Main(string[] args)
        {
            int c;
            int d = 4;
            // c value using out parameter
            Out(out c);
            //d value to ref parameter
            Ref(ref d);
            Console.WriteLine($"value {c}");
            Console.WriteLine($"value {d}");

            Console.ReadLine();
        }
    }
}
