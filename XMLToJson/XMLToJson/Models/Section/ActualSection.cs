using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLToJson.Models.Rules;
using static XMLToJson.Models.Section;

namespace XMLToJson.Models
{
    public class ActualSection
    {
        private static BuildRule buildRule = new BuildRule();

        public ActualSection(Section section)
        {
            this.id = section.id;
            this.parent_id = section.parent_id;
            this.order = section.order;
            this.attributes = section.attributes;
            this.name = "section";
            this.title = "Section";
            this.caption = section.caption;
            this.uud_id = section.uud_id;
            NCReason = section.NCReason;
            timestamp = section.timestamp;

            ReferenceList.reference.Add(id, attributes.caption);
            rules = new List<Rules.Rules>();
            data_queries = new List<Data_Queries>();
            type = "linear";
            layout = "vertical";
            if (!String.IsNullOrEmpty(section.nested.hasRule))
            {
                string ruleString = "";
                if (section.nested.hasRule.Contains("#"))
                {
                    ruleString = section.nested.hasRule.Split('#')[0];
                    int sectionID = ReferenceList.GetReferenceID(ruleString);
                    Rules.Rules rule = new Rules.Rules();
                    rule.statements = buildRule.RuleBuider(section.nested.hasRule, sectionID);
                    rule.actions = new Actions();
                    rules.Add(rule);
                }
                else
                {
                    Rules.Rules rule = new Rules.Rules();
                    rule.statements = buildRule.RuleBuider(section.nested.hasRule, id);
                    rule.actions = new Actions();
                    rules.Add(rule);
                }
            }
        }

        public int id { get; set; }
        public int parent_id { get; set; }
        public int order { get; set; }
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
        public SectionAttributes attributes { get; set; }
        public string name { get; set; } 
    }
}
