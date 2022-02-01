using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_product_class2
{
    class Product
    {
        public int id;
        public string name;
        public int price;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[]
                {
                    new Product (){id=1,name = "uspolo" , price =1000},
                    new Product (){id=2,name = "puma",price = 1500},
                    new Product  (){id=3,name = "Nike",price = 1800},
                    new Product  (){id=4,name = "UCB",price  = 2500},
                    new Product  (){id=5,name = "levis",price = 2800},
                };
            //for loop
            for (int i = 0; i < product.Length; i++)
                if (product[i].price >= 1800)
                    Console.WriteLine($" id={product[i].id},Name={product[i].name},price={product[i].price}");
            //foreach loop
            foreach (var e in product)
                if (e.price >= 1800)

                {
                Console.WriteLine($"id ={e.id},Name={e.name},price={e.price}");

            }
            //Lambda expression
           

            product.ToList().Where(e => e.price >= 1800).ToList().ForEach(e => Console.WriteLine($"id = {e.id},Name={e.name},price={e.price}"));

            Console.ReadLine();


        }
    }
}
