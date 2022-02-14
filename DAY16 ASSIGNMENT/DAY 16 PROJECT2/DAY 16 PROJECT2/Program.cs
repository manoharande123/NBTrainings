using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_16_PROJECT2
{
    class Factorial
    {
      

        public void Readinput()
        {
            int input;
            Console.WriteLine("Enter any nummber");
            input = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= input; i++)
                fact = fact * i;
            Console.WriteLine(fact);

        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial();
            f.Readinput();

            Console.ReadLine();
           
        }
    }
}
