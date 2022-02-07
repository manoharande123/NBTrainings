using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY11_PROJECT_2
{
    class Employees
    {
        private int id;
        private string name;
        private string designation;
        private int salary; 

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }
        public string Name
        {
            get
            {
                return name ;
            }
            set
            {
                name  = value;
            }

        }
        public string Designation
        {
         
            set
            {
                designation = value;
            }

        }
        public int Salary
        {
            get
            {
                salary = (designation == "S") ? 30000 : 60000;
                return salary;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees e = new Employees();
            e.Designation = "M";
            Console.WriteLine($"salary = {e.Salary}");
            Console.ReadLine();
        }
    }
}
