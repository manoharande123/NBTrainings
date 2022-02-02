using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8__Class_emoloyees
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
            List<Employees> employees = new List<Employees>
           {
                new Employees() {id = 1, name = "MANOHAR" ,salary = 5000},
                new Employees() {id = 2, name = "shashank" ,salary = 5000},
                new Employees () {id = 3, name = " Sharath", salary = 7000},
                new Employees () {id = 4, name = " Kiran", salary = 8000},
                new Employees () {id = 5,name = " sandeep", salary = 9000},



           };
           // for loop;
           for (int i = 0; i< employees.Count; i++)
            {
                Console.WriteLine($"id ={employees[i].id},name ={employees[i].name}, salary ={employees[i].salary}");
            }
           //for each
           foreach(var e in employees)
            {
                Console.WriteLine($"id = {e.id}, name = {e.name}, salary ={e.salary}");
            }
            //for Lambda expression
            employees.ToList().ForEach(e => Console.WriteLine($"id = {e.id},name={e.name},salary = {e.salary}"));

            //LINQ query
            var result = from e in employees
                         select e;
            result.ToList().ForEach(e => Console.WriteLine($"id = { e.id},name ={ e.name},salary = { e.salary}"));
            Console.ReadLine();
            
                          



        }
    }
}
