using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7__morning_project1
    //*******************************************************************
    //Author: ANDE MANOHAR
    //Purpose : To create Employee class with three variables and two methods
    //*******************************************************************

{
    class Employees
    {
        private int Id;
        private string Name;
        private int Salary;
        public void ReadEmployee()
        {
            Console.WriteLine("Enter Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter salary");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public void printEmployee()
        {
            Console.WriteLine($"Id = {Id},Name={Name},Salary={Salary}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees Emp1 = new Employees();
            Employees Emp2 = new Employees();

            Emp1.ReadEmployee();
            Emp2.ReadEmployee();

            Emp1.printEmployee();
            Emp2.printEmployee();

            Console.ReadLine();

        }

    }
}
