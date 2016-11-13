using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToJson.Models
{
    public class SectionAttributes
    {
        [XmlAttribute("freq")]
        public string freq { get; set; } = "";
        [XmlAttribute("colour")]
        public string colour { get; set; } = "";
        [XmlText]
        public string caption { get; set; } = "";
        [XmlAttribute("type")]
        public string type { get; set; } = "";
        [XmlAttribute("add_caption")]
        public string add_caption { get; set; } = "";
        [XmlAttribute("next_caption")]
        public string next_caption { get; set; } = "";
        [XmlAttribute("prev_caption")]
        public string prev_caption { get; set; } = "";
        [XmlAttribute("totals")]
        public string totals { get; set; } = "";
        [XmlAttribute("datetime")]
        public string datetime { get; set; } = "";
        [XmlAttribute("allowdel")]
        public string allowdel { get; set; } = "";
        [XmlAttribute("timer")]
        public string timer { get; set; } = "";
        [XmlAttribute("groupby")]
        public string groupby { get; set; } = "";
        [XmlAttribute("grouped")]
        public string grouped { get; set; } = "";
        [XmlAttribute("rowrequired")]
        public string rowrequired { get; set; } = "";
        [XmlAttribute("hide")]
        public string hidden { get; set; } = "";
        [XmlAttribute("style")]
        public string style { get; set; } = "";
        [XmlAttribute("sql")]
        public string sql { get; set; } = "";
        [XmlAttribute("delsql")]
        public string delsql { get; set; } = "";
        [XmlAttribute("tablefiltercolumn")]
        public string tablefilter { get; set; } = "";
    }
}
