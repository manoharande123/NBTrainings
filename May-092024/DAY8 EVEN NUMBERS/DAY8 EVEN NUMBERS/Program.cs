using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_EVEN_NUMBERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int> { 24, 29, 32, 40, 55, 58, 60, 65 };


            //forlooop
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] % 2 == 0)
                    Console.WriteLine(data[i]);
            }

            //foreach loop
            foreach(var d in data)
                if(d%2 ==0)
                {
                    Console.WriteLine(d);
                }
            // lamda expression
            data.ToList().Where(d => d % 2 == 0).ToList().ForEach(d => Console.WriteLine(d));

            // LING query
            var result = from d in data
                         where d % 2 == 0
                         select d;
            result.ToList().ForEach(d => Console.WriteLine(d));
            Console.ReadLine();

        }
    }
}
