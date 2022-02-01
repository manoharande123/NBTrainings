using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_Morning_project2
{
    //*******************************************************************
    //Author: ANDE MANOHAR
    //Purpose : To create Customer class with three variables and two methods
    //*******************************************************************

    class customer
    {
        private string username;
        private string password;
        private string email;
        public void Readcustomer()
        {
            Console.WriteLine("Enter username :");
            username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            password = Console.ReadLine();
            Console.WriteLine("Enter email :");
            email = Console.ReadLine();


        }
        public void Printcustomer()
        {
            Console.WriteLine($"username={username},password={password},email={email}:");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer Cust1 = new customer();
            customer Cust2 = new customer();

            Cust1.Readcustomer();
            Cust2.Readcustomer();

            Cust1.Printcustomer();
            Cust2.Printcustomer();

            Console.ReadLine();







         


        }
    }
}
