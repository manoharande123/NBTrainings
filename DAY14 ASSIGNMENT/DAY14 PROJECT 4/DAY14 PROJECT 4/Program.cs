using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY14_PROJECT_4
{
    //AUTHOR : ANDE MANOHAR
    //PURPOSE: WACP TO CHECK GIVEN NUMBER IS PRIME OR NOT
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            int n = 13, i;
            for(i=2;i<n;i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i == n)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
            Console.ReadLine();
        }
    }
}
