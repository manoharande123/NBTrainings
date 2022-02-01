using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_customer_project2
{
    class Customers
    {
        public int id;
        public string name;
        public int age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customers[] customers = new Customers[]
                {
                    new Customers (){id=1,name = "Manohar",age = 20},
                    new Customers (){id=2,name = "Mohan",age = 15},
                    new Customers (){id=3,name = "Ramu",age = 18},
                    new Customers (){id=4,name = "krishna",age  = 25},
                    new Customers (){id=5,name = "Kiran",age = 28},
                };
            //for loop
            
                for (int i = 0; i < customers.Length; i++)
                if (customers[i].age >= 20)
                    Console.WriteLine($" id={customers[i].id},Name={customers[i].name},age={customers[i].age}");
            //foreach loop
            foreach (var e in customers)
                if (e.age >= 20)

                {
                Console.WriteLine($"id ={e.id},Name={e.name},age={e.age}");

            }
            //Lambda expression
            customers.ToList().Where(e => e.age >=20).ToList().ForEach(e => Console.WriteLine($"id = {e.id},Name={e.name},age={e.age}"));
 

            Console.ReadLine();


        }
    }
}
