using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_9_constructor_employyes__project
{
    //*******************\\
    //Author:ANDE MANOHAR
    //Purpose:Employee class with two constructors

    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NationsBenefits";

        public Employee()
        {
            id = 0;
            name = null;
            salary = 0;
        }
        public Employee(int eid, string emane, int esalary)
        {
            id = eid;
            name = emane;
            salary = esalary;

        }
        public void ReadData()
        {
            Console.WriteLine("Enter Employee Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary:");
            salary = Convert.ToInt32(Console.ReadLine());

        }
        public void PrintData()
        {
            Console.WriteLine($"id:{id},Name={name},salary={salary},company={company}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.PrintData();

            Console.ReadLine();
        }
    }
}
