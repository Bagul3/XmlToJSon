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
        public string Options { get; set; }
        [XmlAttribute("code")]
        public string Code { get; set; }
        [XmlAttribute("required")]
        public string Required { get; set; }
        [XmlAttribute("hide")]
        public string Hide { get; set; }
    }
}
