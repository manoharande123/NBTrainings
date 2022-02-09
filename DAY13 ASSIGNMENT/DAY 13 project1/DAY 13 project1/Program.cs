using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_13_project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            data[0, 0] = 8;
            data[0, 1] = 11;
            data[1, 0] = 14;
            data[1, 1] = 13;


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i,j]+" ");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();

        }
    }
}
