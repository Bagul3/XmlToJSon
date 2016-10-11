using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLToJson.Models.Misc;

namespace XMLToJson.Models.IndividualFields.Actual
{
    public class ActualTextFieldAttributes
    {
        public ActualTextFieldAttributes()
        {

        }
        
        public ActualTextFieldAttributes(FieldAttributes textfield)
        {
            caption = textfield.caption;
            requiredgroup = textfield.requiredgroup;
            hidden = textfield.hidden;
            Default = textfield.Default;
            issupplier = textfield.issupplier;
            code = textfield.code;
            required = textfield.required;
        }

        public string caption { get; set; }

        public string helpertext { get; set; }

        public string required { get; set; }
        
        public string requiredgroup { get; set; }

        public string expected { get; set; }

        public string validregex { get; set; }

        public string Readonly { get; set; }
        
        public string hidden { get; set; }

        public string regex { get; set; }

        public string example { get; set; }

        public string forcecaptial { get; set; }

        public string max { get; set; }

        public string min { get; set; }

        public string value { get; set; }
        
        public string Default { get; set; }

        public string format { get; set; }

        //Has default value in formbuilder
        public string buttons { get; set; }

        public List<Step> step { get; set; }

        public string severity { get; set; }

        public List<Metadata> metadata { get; set; }

        //TODO set default value
        public string mailmerge { get; set; }

        //has default
        public string isproduct { get; set; }

        //has default
        public string iscustomer { get; set; }

        //has default
        public string isbatch { get; set; }

        //has default
        public string isline { get; set; }

        //has default
        public string issupplier { get; set; }

        public string style { get; set; }

        public string inputstyle { get; set; }
        
        public string code { get; set; }

        //has default value
        public string iscasename { get; set; }

        //default value
        public string casestatusupdate { get; set; }

        public string allowncoveride { get; set; }

        public List<Pictures> pictures { get; set; }
    }
}
