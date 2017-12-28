using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLPractice
{
    public class XMLDocument
    {
        public static void Print(string path)
        {
            XmlTextReader xmlReader = new XmlTextReader(path);

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element) Console.Write(xmlReader.Name + "  ");
            }

            Console.ReadLine();
        }
    }
}
