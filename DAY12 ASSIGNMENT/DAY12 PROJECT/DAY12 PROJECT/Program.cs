using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY12_PROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("enter a:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Division of two numbers is {0}", c);

            }
            catch (OverflowException)
            {
                Console.WriteLine("enter numbers between 0 o 600000");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Number cant be divided by zero");

            }
            catch (FormatException)
            {
                Console.WriteLine("Enter numbers only");

            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, Manohar");

            }
            finally
            {
                Console.WriteLine("\n \n \n \n \n Designed by  Manohar");
                Console.ReadLine();



            }
        }
    }
}
