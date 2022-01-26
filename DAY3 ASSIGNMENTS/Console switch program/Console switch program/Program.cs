using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_switch_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable declaration
            char input;
            Console.WriteLine("Enter characers");
            input = Convert.ToChar(Console.ReadLine());

            //Logic
            switch(input)
            {
                case 'a':

                case 'e':

                case 'i':

                case 'o':

                case 'u':


                    Console.WriteLine("The input given  vowel" );
                    break;
                default:
                    Console.WriteLine("The input  is Consonant ");
                    break;






            }
            Console.ReadLine();
        }
    }
}
