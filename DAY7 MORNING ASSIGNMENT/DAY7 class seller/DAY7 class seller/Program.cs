using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_class_seller
{
    //*******************************************************************
    //Author: ANDE MANOHAR
    //Purpose : To create seller class with three variables and two methods
    //*******************************************************************
    class seller
    {
        private string name;
        private string email;
        private int mobile;
        public void Readseller()
        {
            Console.WriteLine("Enter sellername :");
            name = Console.ReadLine();
            Console.WriteLine("Enter email:");
            email = Console.ReadLine();
            Console.WriteLine("Enter mobile number :");
            mobile = Convert.ToInt32(Console.ReadLine());
        }
        public void Printseller()
        {
            Console.WriteLine($"name={name},email={email},mobile={mobile}");


        }
        internal class Program
        {
            static void Main(string[] args)
            {
                seller s1 = new seller();
                seller s2 = new seller();

                s1.Readseller();
                s2.Readseller();

                s1.Printseller();
                s2.Printseller();

                Console.ReadLine();


            }
        }
    }
}