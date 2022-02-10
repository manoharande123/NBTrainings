using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_project_2
{
    class Rectangle
    {
        private int length;
        private int breadth;
        private int area;
         
        public int Length
        {
            set
            {
                length = value;        
            }
        }
        public int Breadth
        {
            set
            {
                breadth = value;
            }
        }
        public int Area
        {
            get
            {
                area  = length * breadth;
                return area;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle();           
            a.Length = 5;
            a.Breadth = 6;

            Console.WriteLine("Area of recangle is:{0}",a.Area);
            Console.ReadLine();
        }
    }
}
