using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAY19_PROJECT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("C:\\Xml  projects\\Products file.xml");

            //XmlNode node = doc.DocumentElement.SelectSingleNode("/Products/product");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode cnode in node.ChildNodes)

                {
                    if (cnode.Name=="Name")
                    {
                        Console.WriteLine(cnode.InnerText);
                    }
                   
                }
               

            }
            Console.ReadLine();



        }
        

    }
}
