using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY13_PROJECT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int [,] data = new [,] { { 1, 2, 3 }, { 2, 4, 5 }, {4, 6, 6 } };
            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                        sum = sum + data[i, j];
                }
                
            }
            Console.WriteLine(sum);
            Console.ReadLine();


        }
    }
}
