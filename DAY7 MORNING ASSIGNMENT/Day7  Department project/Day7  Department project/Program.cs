using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7__Department_project
{

    //*******************************************************************
    //Author: ANDE MANOHAR
    //Purpose : To create Department class with three variables and two methods
    //*******************************************************************
    class department
    {
        private string dealername;
        private string email;
        private int mobile;
        public void Readdepartment()
        {
            Console.WriteLine("Enter dealername :");
            dealername = Console.ReadLine();
            Console.WriteLine("Enter email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter mobile number :");
            mobile = Convert.ToInt32(Console.ReadLine());
        }
        public void Printdepartment()
        {
            Console.WriteLine($"dealername={dealername},email={email},mobile={mobile}");


        }


        internal class Program
        {
            static void Main(string[] args)
            {
                department d1 = new department();
                department d2 = new department();

                d1.Readdepartment();
                d2.Readdepartment();

                d1.Printdepartment();
                d2.Printdepartment();

                Console.ReadLine();



            }
        }  
    }
}
