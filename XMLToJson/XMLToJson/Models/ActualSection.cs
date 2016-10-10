using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models
{
    public class ActualSection
    {
        public ActualSection(Section section)
        {
            this.id = section.id;
            this.parent_id = section.parent_id;
            this.order = section.order;
            this.attributes = section.attributes;
            this.title = section.title;
            this.caption = section.caption;
            this.uud_id = section.uud_id;
            this.NCReason = section.NCReason;
            this.timestamp = section.timestamp;
        }

        public int id { get; set; }
        public int parent_id { get; set; }
        public int order { get; set; }
        public SectionAttributes attributes { get; set; }
        //public string name { get; set; }   
        public string title { get; set; }
        public string caption { get; set; }
        public string uud_id { get; set; }
        public string NCReason { get; set; }
        public string job_id { get; set; }
        public string timestamp { get; set; }
    }
}
