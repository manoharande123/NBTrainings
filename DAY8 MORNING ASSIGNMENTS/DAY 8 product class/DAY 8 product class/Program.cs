using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_8_product_class
{
    class Product
    {
        public int id;
        public string name;
        public int price;
        public string brand;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>
            {
                
                new Product() {id = 1, name = "Sanitizer" ,price = 100, brand = "hygenix" },
                new Product() {id = 2, name = "shoes" ,price = 500, brand = "puma" },
                new Product() {id = 3, name = "shirts" ,price = 1000, brand = "levis" },
                new Product() {id = 4, name = "watch" ,price = 1200, brand = "fastrack" },
                new Product() {id = 5, name = "Bottle" ,price = 500,brand = "Milton" },               
           };
            // for loop;
            for (int i = 0; i < product.Count; i++)
            {
                if (product[i].price >= 500)
                    Console.WriteLine($"id ={product[i].id},name ={product[i].name}, price ={product[i].price}, brand = {product[i].brand}");
            }
            //for each
            foreach (var p in product)
            {
                if (p.price >= 500)
                    Console.WriteLine($"id = {p.id}, name = {p.name}, price ={p.price}, brand ={p.brand}");
            }
            //for Lambda expression
            product.ToList().Where(p => p.price >= 500).ToList().ForEach(p => Console.WriteLine($"id = {p.id},name={p.name},price = {p.price},brand ={p.brand}"));

            //LINQ queryp
            var result = from p in product
                         where p.price >=500
                         select p;
            result.ToList().ForEach(p => Console.WriteLine($"id = { p.id},name ={ p.name},price= { p.price},brand = {p.brand}"));
            Console.ReadLine();




        }
    }
    
}
