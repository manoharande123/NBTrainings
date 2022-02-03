using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search_program
{
    //Author : Ande Manohar
    //Purpose : Binary search program
    //************************************//
    internal class Program
    {
        //Implementing usuing binary search Method
        public static int Binarysearch (int[]a, int b)
        {
            int left = 0; //start
            int right = a.Length - 1; // end 
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (b<a[mid])
                {
                    right = mid - 1;
                }
                else if (b>a[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return 0; // if all conditions are fail
        }
        static void Main(string[] args)
        {
            //Array declaration and initializaion
            int[] a = new int[] { 10, 15, 17, 22, 27, 28, 29, 30 };
            // search an element in the array 
            Console.WriteLine(" Enter search element :");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = Binarysearch(a, b);
            if (result <= 0)
            {
                Console.WriteLine($"search item{b} not found");
            }
            else
            {
                Console.WriteLine($"search item {b} found at index {result}");

            }
            Console.ReadLine();

        }
    }
}
