using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 18, 10, 26, 15, 50 };
            int temp;
            for (int i = 0; i<= a.Length -2; i++)
            {
                for (int j = 0; j <= a.Length -2; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            foreach (var p in a)
                Console.WriteLine(p);
            Console.ReadLine();

        }
    }
}
