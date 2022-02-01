using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_7_Employees_using_public
{
    class Employees
    {
        public int id;
        public string name;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees[] employees = new Employees[]
                {
                    new Employees (){id=1,name = "Manohar",salary = 5000},
                    new Employees (){id=2,name = "Mohan",salary = 6000},
                    new Employees (){id=3,name = "Ramu",salary = 7000},
                    new Employees (){id=4,name = "krishna",salary = 9000},
                    new Employees (){id=5,name = "Kiran",salary = 10000},
                };
            //for loop
            for (int i = 0; i < employees.Length; i++)
                Console.WriteLine($" id={employees[i].id},Name={employees[i].name},salary={employees[i].salary}");
            //foreach loop
            foreach(var e in employees)
            {
                Console.WriteLine($"id ={e.id},Name={e.name},salary={e.salary}");

            }
            //Lambda expression
            employees.ToList().ForEach(e => Console.WriteLine($"id = {e.id},Nmae={e.name},salary={e.salary}"));

            Console.ReadLine();

        }
    }
}
