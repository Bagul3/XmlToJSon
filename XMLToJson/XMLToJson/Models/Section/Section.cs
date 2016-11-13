using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLToJson.Models.Misc;

namespace XMLToJson.Models
{
    public class Section
    {
        public Section()
        {
            Global.id++;
            id = Global.id;
            Global.parent_id = id;
            Global.order++;
            order = Global.order;
            parent_id = 0;
            rules = new List<Rules.Rules>();
            data_queries = new List<Data_Queries>();
            type = "linear";
            layout = "vertical";            
        }
        public int id { get; set; }
        public int parent_id { get; set; }
        public int order { get; set; }
        [XmlElement("name")]
        public SectionAttributes attributes { get; set; }

        [XmlElement("fields")]
        public Nest nested { get; set; }
        
        public class Nest
        {
            [XmlAttribute("hide")]
            public string hasRule { get; set; }
            [XmlElement("field")]
            public List<FieldAttributes> field { get; set; }            
        }
        public string title { get; set; } = "";
        public string caption { get; set; } = "";
        public string uud_id { get; set; }
        public string NCReason { get; set; } = "";
        public string job_id { get; set; } = "";
        public string timestamp { get; set; } = "";
        public List<Pictures> pictures { get; set; }
        public List<Rules.Rules> rules { get; set; }
        public List<Data_Queries> data_queries { get; set; }
        public string type { get; set; }
        public string layout { get; set; }    
    }
}
