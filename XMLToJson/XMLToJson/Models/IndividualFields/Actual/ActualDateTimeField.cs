using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLToJson.Models.Misc;
using XMLToJson.Models.Rules;

namespace XMLToJson.Models.IndividualFields.Actual
{
    public class ActualDateTimeField
    {
        private static BuildRule buildRule = new BuildRule();

        public ActualDateTimeField()
        {

        }

        public ActualDateTimeField(FieldAttributes textfield)
        {
            name = textfield.name;
            caption = textfield.caption;
            id = textfield.id;
            parent_id = textfield.parent_id;
            order = textfield.order;
            hasRule = textfield.Hide;
            order = textfield.order;
            rules = new List<Rules.Rules>();
            actions = new List<Actions>();
            ReferenceList.reference.Add(textfield.caption, id);
            if (textfield.Hide != null)
            {
                Rules.Rules rule = new Rules.Rules();
                rule.statements = buildRule.RuleBuider(textfield.Hide, id);
                rules.Add(rule);
                actions.Add(new Actions());
            }
            data_queries = new List<Data_Queries>();
        }

        public int id { get; set; }

        public int parent_id { get; set; }

        public int order { get; set; }

        public ActualDateTimeFieldAttributes attributes { get; set; }

        public string caption { get; set; } = "";

        public List<Pictures> pictures { get; set; }

        public string name { get; set; } = "";

        //TODO set default value
        public string title { get; set; } = "";

        public List<Rules.Rules> rules { get; set; }

        public List<Actions> actions { get; set; }

        public List<Data_Queries> data_queries { get; set; }

        //has default
        public string uuid { get; set; }

        public string NCReason { get; set; } = "";

        public string job_id { get; set; } = "";

        public List<Row> row { set; get; }

        public string timestamp { get; set; } = "";

        public string hasRule { get; set; } = "";

        //has default value
        public string calculator { get; set; }
    }
}
