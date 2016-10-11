using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLToJson.Models.Misc;

namespace XMLToJson.Models.IndividualFields.Actual
{
    public class ActualRadioField
    {
        public ActualRadioField()
        {

        }

        public ActualRadioField(FieldAttributes textfield)
        {
            name = textfield.name;
            caption = textfield.caption;
            id = textfield.id;
            parent_id = textfield.parent_id;
            order = textfield.order;
        }

        public int id { get; set; }

        public int parent_id { get; set; }

        public int order { get; set; }

        public ActualRadioFieldAttributes attributes { get; set; }

        public string caption { get; set; }

        public List<Pictures> pictures { get; set; }

        public string name { get; set; }

        //TODO set default value
        public string title { get; set; }

        public List<Rule> rules { get; set; }

        public List<Data_Queries> data_queries { get; set; }

        //has default
        public string uuid { get; set; }

        public string NCReason { get; set; }

        public string job_id { get; set; }

        public List<Row> row { set; get; }

        public string timestamp { get; set; }

        //has default value
        public string calculator { get; set; }
    }
}
