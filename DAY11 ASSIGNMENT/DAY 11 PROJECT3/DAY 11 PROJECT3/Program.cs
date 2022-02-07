using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_11_PROJECT3
{
    class Employee
    {

        public int Id
        {
            get
            {
                return Id;
            }
            set
            {
               Id = value;
            }

        }
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }

        }
        public string Designation
        {
            set
            {
                Designation = value;
            }

        }
        public int Salary
        {
            get
            {
                Salary = (Designation == "S") ? 30000 : 60000;
                return Salary;
            }
        }
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Designation = "M";
            Console.WriteLine($"Salary : {e.Salary}");
            Console.ReadLine();

        }

        
        }
    }

