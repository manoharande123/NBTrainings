using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_14_PROJECT_1
{
    sealed class Employee
    {
        public int PrintId()
        {
            return 100;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine(e.PrintId());

            Console.ReadLine();

            
        }
    }
}
