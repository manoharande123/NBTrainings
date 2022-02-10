using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_14_PROJECT2.B
{
    class Rectangle
    {
        private int length;
        private int breadth;
        private int area;
        public int Area

        {
            get
            {
                area = length * breadth;
                return area;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Rectangle a = new Rectangle();
                a.length = 5;
                a.breadth = 6;

                Console.WriteLine("Area of recangle is:{0}", a.Area);
                Console.ReadLine();

            }
        }    }
}
