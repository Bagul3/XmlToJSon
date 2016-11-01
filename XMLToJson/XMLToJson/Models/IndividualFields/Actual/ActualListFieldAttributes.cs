using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLToJson.Models.Misc;

namespace XMLToJson.Models.IndividualFields.Actual
{
    public class ActualListFieldAttributes
    {
        public ActualListFieldAttributes()
        {

        }

        public ActualListFieldAttributes(FieldAttributes listField)
        {
            caption = listField.caption;
            requiredgroup = listField.requiredgroup;
            required = listField.required;
            hidden = listField.hidden;
            issupplier = listField.issupplier;
            code = listField.Code;
            Options = listField.Options;
        }

        
        public string caption { get; set; } = "";

        public string helpertext { get; set; } = "";

        public List<Options> Options { get; set; }
        
        public string required { get; set; } = "";

        public string requiredgroup { get; set; } = "";

        public string expected { get; set; } = "";

        public string Readonly { get; set; } = "";

        public string hidden { get; set; } = "";

        public string regex { get; set; } = "";

        public string multiple { get; set; } = "";
         
        public string example { get; set; } = "";

        public string value { get; set; } = "";
         
        public string buttons { get; set; } = "";

        public List<Step> step { get; set; }

        public string severity { get; set; } = "";

        public string format { get; set; } = "";

        public List<Metadata> metadata { get; set; }

        //TODO: set to cation value
        public string mailmerge { get; set; } = "";

        //has default
        public string isproduct { get; set; } = "";

        //has default
        public string iscustomer { get; set; } = "";

        //has default
        public string isbatch { get; set; } = "";

        //has default 
        public string isdepartment { get; set; } = "";

        //has default
        public string isline { get; set; } = "";

        //has default
        public string issupplier { get; set; } = "";

        public string style { get; set; } = "";

        //default value
        public string casestatusupdate { get; set; } = "";

        public string code { get; set; } = "";

        public string allowncoveride { get; set; } = "";

    }
}
