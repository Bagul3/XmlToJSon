using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToJson.Models
{
    [XmlRoot("QAConfig")]
    public class QAConfig
    {
        [XmlElement("form")]
        public Form Form { get; set; }
    }
}
