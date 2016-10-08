using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using XMLEngine;

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
            List<KeyValuePair<string, List<KeyValuePair<string, dynamic>>>> results =  ActionValues(@"C:\Users\Conor\Desktop\sections.xml");
            var result2 = GetAttributes(results.ElementAt(0).Value.ElementAt(0));
        }

        public static List<KeyValuePair<string, List<KeyValuePair<string, dynamic>>>> ActionValues(string xmlPath)
        {
            List<KeyValuePair<string, List<KeyValuePair<string, object>>>> keyValuePairList1 = new List<KeyValuePair<string, List<KeyValuePair<string, object>>>>();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlPath);
            foreach (XmlNode childNode1 in xmlDocument.ChildNodes)
            {
                if (childNode1.Name.Equals("section"))
                {
                    foreach (XmlNode childNode2 in childNode1.ChildNodes)
                    {
                        IEnumerable<XmlNode> xmlNodes = childNode2.ChildNodes.Cast<XmlNode>();
                        List<KeyValuePair<string, object>> keyValuePairList2 = new List<KeyValuePair<string, object>>();
                        foreach (XmlNode xmlNode in xmlNodes)
                            keyValuePairList2.Add(new KeyValuePair<string, object>(xmlNode.Name + "," + xmlNode.Attributes, (object)xmlNode));
                        keyValuePairList1.Add(new KeyValuePair<string, List<KeyValuePair<string, object>>>(childNode2.Name, keyValuePairList2));
                    }
                }
            }
            return keyValuePairList1;
        }

        private static List<KeyValuePair<string, dynamic>> GetAttributes(KeyValuePair<string, dynamic> properties)
        {
            var xml = properties.Value as XmlText;
            var doc = new XmlDocument();
            var nodeValues = new List<KeyValuePair<string, dynamic>>();
            var xmlBuilder = "<action>" + xml.InnerXml + "</action>";
            doc.LoadXml(xmlBuilder);
            foreach (XmlNode xmlProperties in doc.ChildNodes)
            {
                var nodes = xmlProperties.ChildNodes.Cast<XmlNode>();
                foreach (var node in nodes)
                    nodeValues.Add(new KeyValuePair<string, dynamic>(node.Name, node.InnerText));
            }
            return nodeValues;
        }
    }
}
