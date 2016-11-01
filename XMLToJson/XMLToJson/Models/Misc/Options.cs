using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLToJson.Models.Misc;

namespace XMLToJson.Models
{
    public class Options
    {
        [XmlAttribute("nc")]
        public string servity { get; set; }
        [XmlText]
        public string value { get; set; }
        /*[XmlAttribute("if")]
        public Statement statement { get; set; } */
    }
}
