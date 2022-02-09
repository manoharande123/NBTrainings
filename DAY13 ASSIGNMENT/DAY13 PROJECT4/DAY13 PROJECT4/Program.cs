using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY13_PROJECT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];
            //read data from user
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter array value :");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //print data from user
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(data[i, j]+ " ");                   
                }
                Console.WriteLine();                
            }
            Console.ReadLine();
        }

    }    
}
