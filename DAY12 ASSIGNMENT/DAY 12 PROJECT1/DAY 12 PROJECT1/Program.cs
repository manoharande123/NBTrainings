using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_12_PROJECT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try

            {
                int a, b, c;
                Console.WriteLine("Enter first number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("division of two numbers is {0}", c);
                Console.ReadLine();

            }
            catch (OverflowException)// This is for overflow exception

            {
                Console.WriteLine("Only nummbers between 0 to 900000");

            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" Can not divide with zero");

            }
            catch (Exception)
            {
                Console.WriteLine("some error occured please contact admin");
            }
            finally
            {
                Console.WriteLine(" Designed by Manohar");
                Console.ReadLine();
            }
        }
    }
}
