using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_15__PROJECT_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Copy("D:\\NBTRAININGS\\DAY15 ASSIGNMENT\\New folder (3)\\Mydata.txt", "D:\\NBTRAININGS\\DAY15 ASSIGNMENT\\New folder\\Mydata.txt");



            Console.WriteLine("File copy done");
            Console.ReadLine();
        }
    }
}
