using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_using_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add ("Manohar");
            data.Add("praveen");
            data.Add("ram");
            data.Add("vinay");

            //print using for loop
             for (int i=0;i<data.Count; i++)
            {
                Console.WriteLine(data[i]);

            }
             //print values foreach loop
             foreach(var d in data)

            {
                Console.WriteLine(d);

            }
             //print using lambda
             data.ForEach(p=>Console.WriteLine(p));
           
            
             Console.ReadLine();

        
        }
    }
}
