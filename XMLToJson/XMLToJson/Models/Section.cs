using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToJson.Models
{
    [XmlRoot("section")]
    public class Section
    {
        [XmlAttribute("freq")]
        public string freq { get; set; }
        [XmlAttribute("colour")]
        public string colour { get; set; }

        [XmlArray("fields")]
        [XmlArrayItem("field")]
        public List<FieldAttributes> FormAttributes { get; set; }           
    }
}
