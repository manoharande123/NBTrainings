using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7__product
{
    //*******************************************************************
    //Author: ANDE MANOHAR
    //Purpose : To create Product class with three variables and two methods
    //*******************************************************************
    class Product
    {
        private int price;
        private string brand;
        private string colour;
        public void ReadProduct()
        {
            Console.WriteLine("Enter price");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter brand");
            brand = Console.ReadLine();
            Console.WriteLine("Enter colour");
            colour = Console.ReadLine();

        }
        public void Printproduct()
        {
            Console.WriteLine($"price{price},brand{brand}colour{colour}");
        }



    internal class Program
        {

            static void Main(string[] args)
            {
                Product p1 = new Product();
                Product p2 = new Product();

                p1.ReadProduct();
                p2.ReadProduct();

                p1.Printproduct();
                p2.Printproduct();

                Console.ReadLine();

            }
        }






    }

}

