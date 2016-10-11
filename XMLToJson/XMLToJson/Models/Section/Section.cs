using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToJson.Models
{
    public class Section
    {
        public Section()
        {
            Global.id++;
            id = Global.id;
            Global.parent_id = id;
            parent_id = 0;
        }
        private static int idCount { get; set; }
        public int id { get; set; }
        public int parent_id { get; set; }
        public int order { get; set; }
        [XmlElement("name")]
        public SectionAttributes attributes { get; set; }
        [XmlArray("fields")]
        [XmlArrayItem("field")]
        public List<FieldAttributes> field { get; set; }
        //public string Name { get; set; }   
        public string title { get; set; }
        public string caption { get; set; }
        public string uud_id { get; set; }
        public string NCReason { get; set; }
        public string job_id { get; set; }
        public string timestamp { get; set; }
    }
}
