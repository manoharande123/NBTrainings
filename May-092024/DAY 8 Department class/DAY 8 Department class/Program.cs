using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_8_Department_class
{
    class Department
    {
        public int id;
        public string name;
        public int empcount;
        
    }
 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> department = new List<Department>
            {
                new Department() {id = 100, name = "Departmen1" ,empcount = 100},
                new Department() {id = 101, name = "Deparment2" ,empcount = 40},
                new Department () {id = 102, name = "Deparment3", empcount = 30},
                new Department () {id = 103, name = " Deparment4",empcount =60},
                new Department () {id = 104,name = " Department5", empcount = 70},
            };

            // for loop;
           for (int i = 0; i < department.Count; i++)
            {
                if (department[i].empcount >= 50)
                    Console.WriteLine($"id ={department[i].id},name ={department[i].name}, empcount ={department[i].empcount}");
            }
            //for each
            foreach (var d in department)
            {

                if (d.empcount >= 50)
                    Console.WriteLine($"id = {d.id}, name = {d.name}, empcount ={d.empcount}");
            }
            //for Lambda expression
            department.ToList().Where(d => d.empcount >= 50).ToList().ForEach(d => Console.WriteLine($"id = {d.id},name={d.name},salary = {d.empcount}"));

            //LINQ query
            var result = from d in department
                         where d.empcount >= 50
                         select d;
            result.ToList().ForEach(d => Console.WriteLine($"id = { d.id},namonsole.e ={ d.name},empcount = { d.empcount}"));
            Console.ReadLine();

        }

        }
    }
