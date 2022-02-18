using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAY_19_PROJECT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int input = Convert.ToInt32(Console.ReadLine());

            XmlDocument file = new XmlDocument();
            file.Load("C:\\Xml  projects\\Products file.xml");

            foreach(XmlNode node in file.DocumentElement.ChildNodes)
            {
                foreach(XmlNode cNode in node.ChildNodes)
                {
                    bool ID = cNode.Name == "ID";
                    bool isIndex =( ID == true?
                        Convert.ToInt32(cNode.InnerText) : 0) == input;
                    if (ID && isIndex)
                    {
                        Console.WriteLine($"Name is {cNode.NextSibling.InnerText}."); ;

                    }
                    
                }
            }
            Console.ReadLine();
        }
    }
}
