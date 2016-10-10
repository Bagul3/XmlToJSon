using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToJson.Models
{
    public class Options
    {
        [XmlAttribute("nc")]
        public string Nc { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
