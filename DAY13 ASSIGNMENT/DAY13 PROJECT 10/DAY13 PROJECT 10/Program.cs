using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY13_PROJECT_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> data = new Queue<int>();
            data.Enqueue(20);
            data.Enqueue(35);
            data.Enqueue(45);
            Console.WriteLine(data.Count);          
            Console.WriteLine(data.Dequeue());
            Console.WriteLine(data.Count);


            
            Console.ReadLine();


        }
    }
}
