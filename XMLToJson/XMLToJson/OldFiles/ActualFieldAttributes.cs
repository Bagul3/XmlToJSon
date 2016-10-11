using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models
{
    public class ActualFieldAttributes
    {
        public ActualFieldAttributes()
        {

        }

        public ActualFieldAttributes(FieldAttributes fieldAttributes)
        {
            //group = fieldAttributes.Group;
            //mandatory = fieldAttributes.Mandatory;
            //Default = fieldAttributes.Default;
            //Option = fieldAttributes.Option;            
        }

        public string group { get; set; }
        public string mandatory { get; set; }
        public string Default { get; set; }
        public string Option { get; set; }
        public string Code { get; set; }
        public string Required { get; set; }
        public string Hide { get; set; }
        public Options Options { get; set; }
    }
}
