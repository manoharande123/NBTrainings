using MyClientApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient obj = new WebService1SoapClient();
            Console.WriteLine(obj.Factorial(6));
            Console.WriteLine(obj.Add(5,5));
            Console.WriteLine(obj.Mul(2,3));
            Console.WriteLine(obj.Div(10,2));

            Console.ReadLine()
        }
    }
}
