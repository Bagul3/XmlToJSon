using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLToJson.Models.Misc;

namespace XMLToJson.Models
{
    public class FieldAttributes
    {
        public FieldAttributes()
        {
            Global.id++;
            Global.order++;
            id = Global.id;
            parent_id = Global.parent_id;
            order = order;
        }

        public int id { get; set; }

        public int parent_id { get; set; }

        public int order { get; set; }        

        //Text Field Attributes
        //caption is in both
        [XmlAttribute("title")]
        public string caption { get; set; }

        public string helpertext { get; set; }

        [XmlAttribute("required")]
        public string required { get; set; }

        [XmlAttribute("group")]
        public string requiredgroup { get; set; }

        public string expected { get; set; }

        public string validregex { get; set; }

        public string Readonly { get; set; }

        [XmlAttribute("hide")]
        public string hidden { get; set; }

        public string regex { get; set; }

        public string example { get; set; }

        public string forcecaptial { get; set; }

        public string max { get; set; }

        public string min { get; set; }

        public string value { get; set; }

        [XmlAttribute("default")]
        public string Default { get; set; }

        public string format { get; set; }

        //Has default value in formbuilder
        public string buttons { get; set; }

        public List<Step> step { get; set; }

        public string severity { get; set; }

        public List<Metadata> metadata { get; set; }

        //TODO: set to cation value
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
        [XmlAttribute("updateSupplier")]
        public string issupplier { get; set; }

        public string isdeperatment { get; set; }

        public string style { get; set; }

        public string inputstyle { get; set; }

        [XmlAttribute("code")]
        public string code { get; set; }

        //has default value
        public string iscasename { get; set; }

        //default value
        public string casestatusupdate { get; set; }

        public string allowncoveride { get; set; }
        //End text field attributes

        public List<Pictures> pictures { get; set; }

        [XmlAttribute("type")]
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

        //number field

        // caption 

            //helper text

            // required

            // requiredgroup

            //expected

        //public string validregex { get; set; }

        // readonly 

        //hidden 

        //regex 

        //example

        // format 

        public string button { get; set; }

        public string totalable { get; set; }

        public string sectiontotal { get; set; }

        public string lowerlimit { get; set; }

        public string upperlimit { get; set; }

        //value

        //step

        //severity 

        //metadata

        //mail merge

        //isproduct

        //iscustomer

        //isbatch

        //isline

        //issupplier

        //code

        //style

        //allowncoveride

        //end of number attributes

        // List items 
        // captions
        //helpertext

        [XmlArray("options")]
        [XmlArrayItem("option")]
        public List<Options> Options { get; set; }

        //required
        //requiredgroup
        //expected
        //readonly
        //hidden
        
        public string multiple { get; set; }

        public string lowerdatelimit { get; set; }

        public string upperdatelimit { get; set; }

        private static int idCount { get; set; }

        //example
        //value
        //buttons
        //steps

       

        //unknown:
        //verify
        //linked
    }
}
