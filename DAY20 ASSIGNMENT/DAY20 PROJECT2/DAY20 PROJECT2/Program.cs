using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY20_PROJECT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? Price = 200;

            if(Price.HasValue)
                Console.WriteLine($"Price is {Price}");
            else
                Console.WriteLine("No value");
            Console.ReadLine();
        }
    }
}
