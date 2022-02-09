using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY13_Jagged_Array_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] names = new char[3][];
            names[0] = new char[] { 'm', 'a', 'n', 'u' };
            names[1] = new char[] { 'm', 'a', 'n', 'o', 'h', 'a', 'r' };
            names[2] = new char[] { 'm', 'a', 'n', 'o', 'h', 'a', 'r', 'a', 'n', 'd', 'e' };

            for (int i = 0; i < 3; i++) 
            {
                for(int j =0;j<names[i].Length;j++)
                {
                    Console.Write(names[i][j]+"");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
