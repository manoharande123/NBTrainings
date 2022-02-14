using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_16_project_1
{
    class Message
    {
        public  void PrintHello()
        {
            Console.WriteLine("Hello World");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Message obj = new Message();
            obj.PrintHello();
           
            Console.ReadLine();
        }
    }
}
