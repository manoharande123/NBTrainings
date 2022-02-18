using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Xml  projects\\Products file.xml");
            //XmlNode = doc.DocumentElement.selectsingleNode("/products/product)

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode cnode in node.ChildNodes)
                {
                    if (cnode.Name == "ID")
                        Console.Write(cnode.InnerText + ",");
                    if (cnode.Name == "Name")
                        Console.Write(cnode.InnerText + ",");
                    if (cnode.Name == "Price")
                        Console.Write($"{cnode.InnerText}\n");

                }

            }
            Console.ReadLine();

        }
    }
}
