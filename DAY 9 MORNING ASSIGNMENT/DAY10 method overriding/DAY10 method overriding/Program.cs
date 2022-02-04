using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_method_overriding
{
    class English
    {
        /// <summary>
        /// This Metthod is to print
        /// </summary>
        public void Print()
        {
            Console.WriteLine("good morning");
        }

        public void PrintHeadLine()
        {
            Console.WriteLine("HeadLine");

        }
       
    }
        class Telugu : English
        {
            public new void Print()
            {
                Console.WriteLine("shubodayam");

            }

        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Telugu obj = new Telugu();
            obj.Print();
            obj.PrintHeadLine();
            Console.ReadLine();
            }
        }
    }
