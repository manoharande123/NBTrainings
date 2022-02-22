using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class EmployeeDAL
    {
        public static string filepath = "C:\\ManoharFinalProject\\Employee.txt";

        public static bool AddEmployee(int empid,string empname,int empsalary,int empage)
        {
            //write a code to append data
            try
            {
                string textcontent = string.Concat(empid, ",", empname, ",", empsalary, ",", empage, ",");
                File.AppendAllText(filepath, textcontent + Environment.NewLine);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// This method is used for search ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<string> GetEmpById(int id)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;
            List<string> employeesFound = new List<string>();
            foreach(string employees in allEmployees)
            {
                var employeesDetails = employees.Split(',');
                if (Convert.ToInt32(employeesDetails[0])==id)
                {
                    isFound = true;
                    employeesFound.Add(employees);
                    break;
                }
            }
            return employeesFound;
        }
        /// <summary>
        /// This method is used for search by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<string> GetEmpByName(string name)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;
            List<string> employeesFound = new List<string>();
            foreach (string employees in allEmployees)
            {
                var employeesDetails = employees.Split(',');
                if ((employeesDetails[1]).Contains(name))
                {
                    
                    employeesFound.Add(employees);
                    break;
                }
            }
            return employeesFound;
        }
        /// <summary>
        /// This method is used to DisplayAllEmployees
        /// </summary>
        /// <returns></returns>
        public static string[] DisplayAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filepath);
            return allEmployees;
        }
    }   
}
