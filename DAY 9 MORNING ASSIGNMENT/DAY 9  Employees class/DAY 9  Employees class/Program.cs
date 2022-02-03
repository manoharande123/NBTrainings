using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_9__Employees_class
{
    //Author: MANOHAR ANDE 
    //Purpose:To create an Employee class using varibale and write methods to Readdata and prindata

    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = " Amazone";

        public void ReadData()
        {
            Console.WriteLine("Enter employeee id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employeee name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter employeee salary:");
            salary = Convert.ToInt32(Console.ReadLine());
           
            
            company = "Amazone";


        }

        public void PrintData()
        {
            Console.WriteLine($"id : {id}, name: {name},salary: {salary}, Company: {company}");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();

            emp1.ReadData();
            emp1.PrintData();


            Employee emp2 = new Employee();
            emp2.ReadData();
            emp2.PrintData();

            Console.ReadLine();



        }
    }
}
