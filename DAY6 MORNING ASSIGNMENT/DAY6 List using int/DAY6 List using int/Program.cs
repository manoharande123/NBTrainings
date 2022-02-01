using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6_List_using_int
{
    internal class Program
    {
     
        
            static void Main(string[] args)
            {
                List<int> data = new List<int>();
                int temp;
                int sum1 = 0; int sum2 = 0; int sum3 = 0;
                //Read data from user
                for (int i = 1; i<=5 ; i++)

                {
                    Console.WriteLine("Enter any number:");
                    temp = Convert.ToInt32(Console.ReadLine());
                    data.Add(temp);

                }
                // using forloop
                for(int i = 0; i<data.Count; i++)

            {
                sum1 = sum1 + data[i];
            }

            //sum  using  foreach loop
            foreach (var d in data)

            {
                sum2 = sum2 + d;

                }
                //print using lambda expression
                data.ForEach(p =>  sum3 = sum3+ p);


            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.ReadLine();


            }
        }
    }
