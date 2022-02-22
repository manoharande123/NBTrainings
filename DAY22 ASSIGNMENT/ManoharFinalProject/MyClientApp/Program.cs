using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogicLibrary;

namespace MyClientApp
{
    public static class Program
    {
        public static void AddEmployee()
        {

            //user input
            int empId, empsalary, empage;
            string empname;
            Console.WriteLine("Enter empId:");
            empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            empname = Console.ReadLine();
            Console.WriteLine("Enter Employee salary:");
            empsalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee age:");
            empage = Convert.ToInt32(Console.ReadLine());

            //call BLL
            var result = EmployeesBLL.AddEmployee(empId, empname, empsalary, empage);
            if (result)
                Console.WriteLine("Employee Details saved");
            else
                Console.WriteLine("Error occured");
        }
        public static void GetEmpById()
        {
            //user input
            int empId;
            Console.WriteLine("Enter emp Id:");
            empId = Convert.ToInt32(Console.ReadLine());
            //call BLL
            var result = EmployeesBLL.GetEmpById(empId);
            if (result.Count == 0)
                Console.WriteLine("No data found");
            else
                result.ForEach(d => Console.WriteLine(d));
        }
        public static void GetEmpyName()
        {
            //user input
            string empname;
            Console.WriteLine("Enter name");
            empname = Console.ReadLine();

            //call BLL
            var result = EmployeesBLL.GetEmpByName(empname);
            if (result!= null)
                result.ForEach(d => Console.WriteLine(d));
            else
                Console.WriteLine("No data Found");
        }
        public static void DisplayAllEmployee()
        {
            var result = EmployeesBLL.DisplayAllEmployees();
            result.ToList().ForEach(d => Console.WriteLine(d));         
        }
        static void Main(string[] args)
        {
            int ch;
            string choice;
            do
            {
                Console.WriteLine("Employees Management");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.Search Employee By Id");
                Console.WriteLine("3. search Employee By name");
                Console.WriteLine("4.Display All Employees");
                Console.WriteLine("Enter your choice");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        GetEmpById();
                        break;
                    case 3:
                        GetEmpyName();
                        break;
                    case 4:
                        DisplayAllEmployee();
                        break;
                }
                Console.WriteLine("Do you want to continue(y/n)");
                choice = Console.ReadLine();

            }
            while (choice.Equals("y"));
           
            
        }
    }
}
