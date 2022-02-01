using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_object_initialization_project
{
    class Employee

    {
        public int id;
        public string name;
        public int salary;

    
    }
       
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { id = 2, name = "manohar", salary = 50000 };
            Console.WriteLine($"id ={emp. id},name ={emp.name} salry={emp .salary}");
            Console.ReadLine();
        }
    }
}
