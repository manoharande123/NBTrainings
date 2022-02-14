using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16Project4MultiplicationTable
{
    internal class Multiplication
    {
      
        int input;
        
        public void ReadData()
        {
            Console.WriteLine("Enter any Number");
            input = Convert.ToInt32(Console.ReadLine());
        }
        
        public void GetMultiplication()
        {
            for (int i = 1; i <= +10; i++)
            {
                Console.WriteLine(input + "x" + i + "=" + input * i);
            }
        }

        static void Main(string[] args)
        {
            Multiplication m = new Multiplication();
            m.ReadData();
            m.GetMultiplication();
            Console.ReadLine();
        }
    }
}

