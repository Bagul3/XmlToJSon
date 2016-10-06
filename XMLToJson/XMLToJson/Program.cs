using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLParser();
        }

        public static void XMLParser()
        {
            string xmlFile = File.ReadAllText(@"C:\Users\Conor\Desktop\NIFCC\FQAS\FQAS Inspection Checklist.xml");
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(xmlFile);
            XmlNodeList nodeList = xmldoc.ChildNodes;
            string Short_Fall = string.Empty;
            foreach (XmlNode node in nodeList)
            {
               foreach(XmlElement x in node)
                {
                    Console.WriteLine(x.HasAttributes);
                }
            }

            Console.Read();
        }
    }
}
