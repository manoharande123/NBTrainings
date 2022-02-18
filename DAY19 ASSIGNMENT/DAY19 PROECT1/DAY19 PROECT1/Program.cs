using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace DAY19_PROECT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           XmlDocument doc = new XmlDocument();

            doc.Load("C:\\Xml  projects\\Products file.xml");

            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;
                Console.WriteLine( text);

            }
            Console.ReadLine();
        }
    }
}
