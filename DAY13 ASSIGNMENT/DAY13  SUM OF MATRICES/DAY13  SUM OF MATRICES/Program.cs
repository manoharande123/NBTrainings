using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY13__SUM_OF_MATRICES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] sum = new int[2, 2];
            //Read data fromuser a matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter An array of value a:");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            //Read data from user B matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Enter an Array value of b:");
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            //Addition of two Matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                    Console.Write(sum[i, j]+"  ");
                }
                Console.WriteLine(  );
            }
            
            Console.ReadLine();


        }
            
    }


}
