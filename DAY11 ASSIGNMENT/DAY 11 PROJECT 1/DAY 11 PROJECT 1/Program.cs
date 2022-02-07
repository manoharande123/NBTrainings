using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_11_PROJECT_1
{
    interface Ishape
    {
        int Area();
        int Perimeter();
    }
    class Circle :Ishape
    {
        public int radius;

        public int Area()
        {
            return 22 * radius * radius / 7;
        }


        public int Perimeter()
        {
            return 2 * 22 * radius / 7;
        }

        public void ReadRadius()
        {
            Console.WriteLine("Enter radius:");
            radius = Convert.ToInt32(Console.ReadLine());
        }

    }
    class Square : Ishape
    {
        public int Side;

        public int Area()
        {
            return Side * Side;
        }

        public int Perimeter()
        {
            return 4 * Side;
        }

        public void ReadSide()
        {
            Console.WriteLine("Enter side:");
            Side = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Rectangle : Ishape
    {
        public int l;
        public int b;
        public  void ReadData()
        {
            Console.WriteLine("Enter length:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth:");
            b = Convert.ToInt32(Console.ReadLine());
        }

        public int Area()
        {
            return l*b;
        }

        public int Perimeter()
        {
            return 2 * (l + b);
        }
    }
    class Triangle : Ishape
    {
        public int s, a, b, c;
        public void ReadSide()
        {
            Console.WriteLine("Enter a:");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = Convert.ToInt32(Console.ReadLine());
            s = (a + b + c) / 2;
        }

        public int Area()
        {
            return (int)Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public int Perimeter()
        {
            return 2 * s;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Circle c = new Circle();
                c.ReadRadius();
                Console.WriteLine(c.Area());
                Console.WriteLine(c.Perimeter());

                Square s = new Square();
                s.ReadSide();
                Console.WriteLine(s.Area());
                Console.WriteLine(s.Perimeter());

                Rectangle r = new Rectangle();
                r.ReadData();
                Console.WriteLine(r.Area());
                Console.WriteLine(r.Perimeter());

                Triangle t = new Triangle();
                t.ReadSide();
                Console.WriteLine(t.Area());
                Console.WriteLine(t.Perimeter());
                Console.ReadLine();

            }
        }

    }

}
