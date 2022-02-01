using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_morning_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();
            int sum = 0;


            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(20);

            foreach(var d in data)
            {
                sum = sum + (int)d;

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
