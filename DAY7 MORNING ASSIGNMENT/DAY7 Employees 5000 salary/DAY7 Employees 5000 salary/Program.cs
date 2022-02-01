using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_Employees_5000_salary
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
                    new Employees (){id=4,name = "krishna",salary = 2000},
                    new Employees (){id=5,name = "Kiran",salary = 10000},
                };
            //for loop
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].salary >= 5000)
                    Console.WriteLine($" id={employees[i].id},Name={employees[i].name},salary={employees[i].salary}");
            }
            //foreach loop
            foreach (var e in employees)
            {
                if(e.salary>=5000)
                Console.WriteLine($"id ={e.id},Name={e.name},salary={e.salary}");

            }
            //Lambda expression
            
            
            employees.ToList().Where(e=>e.salary>=5000).ToList().ForEach(e => Console.WriteLine($"id = {e.id},Nmae={e.name},salary={e.salary}"));

            Console.ReadLine();


        }
    }
}
