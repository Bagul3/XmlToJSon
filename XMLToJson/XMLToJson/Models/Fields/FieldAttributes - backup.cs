using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToJson.Models
{
    public class FieldAttributesbackup
    {
        public FieldAttributesbackup()
        {
            Global.id++;
            id = Global.id;
            parent_id = Global.parent_id;
        }

        /// <summary>
        /// Public Fields
        /// </summary>

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
        [XmlAttribute("requiredgroup")]
        public string requiredgroup { get; set; }

        [XmlAttribute("hide")]
        public string Hide { get; set; }
        [XmlArray("options")]
        [XmlArrayItem("option")]
        public List<Options> Options { get; set; }
        [XmlAttribute("mailmerge")]
        public string mailmerge { get; set; }
        [XmlAttribute("severity")]
        public string severity { get; set; }
        [XmlAttribute("port")]
        public string port { get; set; }
        [XmlAttribute("ip")]
        public string ip { get; set; }
        [XmlAttribute("value")]
        public string value { get; set; }
        [XmlAttribute("upperlimit")]
        public string upperlimit { get; set; }
        [XmlAttribute("lowerlimit")]
        public string lowerlimit { get; set; }
        [XmlAttribute("readonly")]
        public string Readonly { get; set; }

        public int id { get; set; }
        public int parent_id { get; set; }
        public int order { get; set; }
        public string caption { get; set; }
        

        /// <summary>
        /// Private Fields
        /// </summary>

        private static int idCount { get; set; }
    }
}
