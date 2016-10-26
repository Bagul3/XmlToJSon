using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLToJson.Models.Misc;

namespace XMLToJson.Models.IndividualFields.Actual
{
    public class ActualNumberFieldAttributes
    {
        public ActualNumberFieldAttributes()
        {

        }

        public ActualNumberFieldAttributes(FieldAttributes numberField)
        {
            caption = numberField.caption;
            requiredgroup = numberField.requiredgroup;
            hidden = numberField.hidden;
            issupplier = numberField.issupplier;
            code = numberField.Code;
            required = numberField.required;
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

        public string format { get; set; }

        //Has default value in formbuilder
        public string buttons { get; set; }

        public string lowerlimit { get; set; }

        public string upperlimit { get; set; }

        public string value { get; set; }

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

        public string code { get; set; }

        public string totalable { get; set; }

        public string sectiontotal { get; set; }             
        
        public string style { get; set; }        

        public string allowncoveride { get; set; }
        
    }
}
