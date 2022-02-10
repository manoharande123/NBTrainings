using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_14_PROJECT_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          for(int i =1;i<=30;i++)
            {
                if (i % 3 == 0)
                    continue;

                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
