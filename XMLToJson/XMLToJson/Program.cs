using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using XMLEngine;
using XMLToJson.Models;

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
            //var results =  ActionValues(@"C:\Users\ConorShannon\Desktop\sections.xml");
            //GetAttributes(results);
            
            var serializer = new XmlSerializer(typeof(Section));
            using (var reader = File.OpenRead(@"C:\Users\ConorShannon\Desktop\sections.xml"))
            {
                Section section = (Section)serializer.Deserialize(reader);
                List<FieldAttributes> attributes = section.FormAttributes;
            }
        }

        //public static List<KeyValuePair<XmlNode, List<KeyValuePair<XmlNode, dynamic>>>> ActionValues(string xmlPath)
        //{
        //    List<KeyValuePair<XmlNode, List<KeyValuePair<XmlNode, object>>>> keyValuePairList1 = new List<KeyValuePair<XmlNode, List<KeyValuePair<XmlNode, object>>>>();
        //    XmlDocument xmlDocument = new XmlDocument();
        //    xmlDocument.Load(xmlPath);
        //    foreach (XmlNode childNode1 in xmlDocument.ChildNodes)
        //    {
        //        if (childNode1.Name.Equals("section"))
        //        {
        //            foreach (XmlNode childNode2 in childNode1.ChildNodes)
        //            {
        //                IEnumerable<XmlNode> xmlNodes = childNode2.ChildNodes.Cast<XmlNode>();
        //                List<KeyValuePair<XmlNode, object>> keyValuePairList2 = new List<KeyValuePair<XmlNode, object>>();
        //                foreach (XmlNode xmlNode in xmlNodes)
        //                    keyValuePairList2.Add(new KeyValuePair<XmlNode, object>(xmlNode, (object)xmlNode.InnerText));
        //                keyValuePairList1.Add(new KeyValuePair<XmlNode, List<KeyValuePair<XmlNode, object>>>(childNode2, keyValuePairList2));
        //            }
        //        }
        //    }
        //    return keyValuePairList1;
        //}

        //private static void GetFields(List<KeyValuePair<XmlNode, dynamic>> properties)
        //{
        //    foreach (var rulesProperties in properties)
        //    {
        //        switch (rulesProperties.Key.Name)
        //        {
        //            case "field":
        //                MapAttributes(rulesProperties);
        //                break;
        //        }
        //    }
            
        //}

        //public static void GetAttributes(List<KeyValuePair<XmlNode, List<KeyValuePair<XmlNode, dynamic>>>> properties)
        //{
        //    foreach (var rulesProperties in properties)
        //    {
        //        switch (rulesProperties.Key.Name)
        //        {
        //            case "fields":
        //                GetFields(rulesProperties.Value);
        //                break;
        //        }
        //    }
        //}

        //public static List<KeyValuePair<XmlNode, dynamic>> MapAttributes(KeyValuePair<XmlNode, dynamic> properties)
        //{
            
        //    foreach(XmlAttribute attribute in properties.Key.Attributes)
        //    {
        //        Console.WriteLine(" " + attribute.Name + " " + " " + attribute.Value);
        //    }

        //    //var doc = new XmlDocument();
        //    //var nodeValues = new List<KeyValuePair<string, dynamic>>();
        //    //var xmlBuilder = "<action>" + xml.InnerXml + "</action>";
        //    //doc.LoadXml(xmlBuilder);
        //    //foreach (XmlNode xmlProperties in doc.ChildNodes)
        //    //{
        //    //    var nodes = xmlProperties.ChildNodes.Cast<XmlNode>();
        //    //    foreach (var node in nodes)
        //    //        nodeValues.Add(new KeyValuePair<XmlNode, dynamic>(node, node.InnerText));
        //    //}
        //    return null;
        //}
    }
}
