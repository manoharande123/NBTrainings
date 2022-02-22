using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;


namespace BussinessLogicLibrary
{
    public static class EmployeesBLL
    {
        public static bool AddEmployee(int empId,string empname,int empsalary,int empage)
        {
            //To do
            var result = EmployeeDAL.AddEmployee(empId, empname, empsalary, empage);
            return result; 
        }
        public static List<string> GetEmpById(int empId)
        {
            var result = EmployeeDAL.GetEmpById(empId);
            return result;
        }
        public static List<string> GetEmpByName(string empname)
        {
            var result = EmployeeDAL.GetEmpByName(empname);
            return result;

        }
        public static string [] DisplayAllEmployees()
        {
            var result = EmployeeDAL.DisplayAllEmployees();
            return result;
        }
    }
}
