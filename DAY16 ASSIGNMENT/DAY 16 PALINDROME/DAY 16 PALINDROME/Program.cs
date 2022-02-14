using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project5Pallindrome
{
    
     class Palindrome
    {
        int input;
        
        public void ReadData()
        {
            Console.WriteLine("Enter any  value");
            input = Convert.ToInt32(Console.ReadLine());
        }
        
        public void CheckPalindrom()
        {
            int sum = 0, rem = 0, temp = input;
            while (input > 0)
            {

                rem = input % 10;
                sum = sum * 10 + rem;
                input = input / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("{0} is a palindrome", temp);
            }
            else
                Console.WriteLine("{0} Given value is Not a Palindrome", temp);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome p = new Palindrome();
            p.ReadData();
            p.CheckPalindrom();
            Console.ReadLine();
        }
    }
}

