using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int score = 0, ans;
            string name;

            //user input
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine("Hi {0}, Welcome to Manohar's Quiz", name);
            Console.WriteLine("*******************************************");
            Console.WriteLine("1.How many days are there in a week?");
            Console.WriteLine("1.8 2.6 3.7 4.9");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;
            Console.WriteLine("2.Who is the cheif Minister of Telangana?");
            Console.WriteLine("1.KCR  2.KTR 3.HARISH ROA 4.K KAVITHA");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 1)
                score += 20;
            Console.WriteLine("3.Who is the Prime Minister of India?");
            Console.WriteLine("1.Manmohan singh 2.Soniya Gandi 3.Narendra Modi 4.Rahul Gandi");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 3)
                score += 20;
            Console.WriteLine("4.How many months are there in a year?");
            Console.WriteLine("1.15  2.12   3.8   4.10");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 2)
                score += 20;
            Console.WriteLine("5.Sun rises in the?");
            Console.WriteLine("1.South 2.West   3.North   4.East");
            Console.WriteLine("Enter your choice:");
            ans = Convert.ToInt32(Console.ReadLine());
            if (ans == 4)
                score += 20;
            if (score >= 60)
                Console.WriteLine($"congrtaualaion! {name} Admin will let you know the  score");
            File.WriteAllText($"D:\\NBTRAININGS\\DAY15 ASSIGNMENT\\QUIZ SCORE.txt", $"Your Score ={score}");

            Console.ReadLine();





        }
    }
}
