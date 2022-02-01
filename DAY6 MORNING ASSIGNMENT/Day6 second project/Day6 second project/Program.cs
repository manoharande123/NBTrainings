using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_second_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;
            data.Add(100);
            data.Add(300);
            data.Add(200);
            data.Add(400);
            data.Add(500);
             foreach(var d in data)
            {
                sum = sum + d;

            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
