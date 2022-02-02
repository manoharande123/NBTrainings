using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_customer_class
  {

    class Customer
    {

        public int id;
        public string name;
        public int age; 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        List<Customer> customer = new List<Customer>
            
        {
                new Customer() {id = 111, name = "Manohar" ,age = 50},
                new  Customer() {id = 222, name = "Rajesh" ,age = 30},
                new  Customer() {id = 333, name = "Madhav" ,age = 25},
                new  Customer() {id = 444, name = "Kalyan" ,age = 20},
                new  Customer() {id = 555, name = "Ramu" ,age = 60},
        };
            // for loop;
            for (int i = 0; i < customer.Count; i++)
               {

                if (customer[i].age >= 30)
                    Console.WriteLine($"id ={customer[i].id},name ={customer[i].name}, age ={customer[i].age}");
            }


            //for each
            foreach (var c in customer)
            {

                if (c.age >= 30)
                    Console.WriteLine($"id = {c.id}, name = {c.name}, age ={c.age}");
            }
            //for Lambda expression
            customer.ToList().Where(c => c.age >= 50).ToList().ForEach(c => Console.WriteLine($"id = {c.id},name={c.name},age = {c.age}"));



            //LINQ query
            var result = from c in customer
                         where c.age >= 30
                         select c;
            result.ToList().ForEach(c => Console.WriteLine($"id = { c.id},namonsole.e ={ c.name},age = { c.age}"));
            Console.ReadLine();



        }
    }
}
