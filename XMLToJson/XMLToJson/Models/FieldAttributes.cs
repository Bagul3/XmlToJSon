using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToJson.Models
{
    public class FieldAttributes
    {
        public FieldAttributes()
        {
            Global.id++;
            id = Global.id;
            parent_id = Global.parent_id;
        }

        [XmlAttribute("title")]
        public string Title { get; set; }
        [XmlAttribute("type")]
        public string Type { get; set; }
        [XmlAttribute("group")]
        public string Group { get; set; }
        [XmlAttribute("mandatory")]
        public string Mandatory { get; set; }
        [XmlAttribute("default")]
        public string Default { get; set; }
        [XmlAttribute("options")]
        public string Option { get; set; }
        [XmlAttribute("code")]
        public string Code { get; set; }
        [XmlAttribute("required")]
        public string Required { get; set; }
        [XmlAttribute("hide")]
        public string Hide { get; set; }
        [XmlArray("options")]
        [XmlArrayItem("option")]
        public List<Options> Options { get; set; }

        public int id { get; set; }
        public int parent_id { get; set; }
        public int order { get; set; }

        private static int idCount { get; set; }
    }
}
