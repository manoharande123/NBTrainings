using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY10_PROJECT4
{
    class Indianexpress
    {
        public virtual void Print()
        {
            Console.WriteLine("Good morning");
        }
        public void Printdata()
        {
            Console.WriteLine("HeadLines");
        }
        public  void Printmain()
        {
            Console.WriteLine("Descripion");
        }
    }
    class Enaadu : Indianexpress
    {
       public override void Print()
        {
            Console.WriteLine("shubodayam");
        }
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Enaadu obj = new Enaadu();
            obj.Print();
            Console.ReadLine();
        }
    }
}
