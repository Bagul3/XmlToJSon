using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLToJson.Models.Misc;

namespace XMLToJson.Models.IndividualFields.Actual
{
    public class ActualDateTimeFieldAttributes
    {
        public ActualDateTimeFieldAttributes()
        {

        }



        public ActualDateTimeFieldAttributes(FieldAttributes listField)
        {
            caption = listField.caption;
            requiredgroup = listField.requiredgroup;
            required = listField.required;
            //code = listField.Code;
            hidden = listField.hidden;
            //metadata = new List<KeyValuePair<object, object>>();    
            //metadata.Add();
        }

        public void keyvalue(object obj)
        {
            
        }

        public string caption { get; set; } = "";

        public string helpertext { get; set; } = "";

        public List<Options> Options { get; set; }

        public string required { get; set; } = "";

        public string requiredgroup { get; set; } = "";

        public string expected { get; set; } = "";

        public string Readonly { get; set; } = "";

        public string hidden { get; set; } = "";

        public string example { get; set; } = "";

        public string value { get; set; } = "";

        public string buttons { get; set; } = "";

        public List<Step> step { get; set; }

        public string severity { get; set; } = "";

        public string format { get; set; } = "";

        public List<Metadata> metadata { get; set; }
    }
}
