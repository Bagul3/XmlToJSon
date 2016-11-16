using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models.Rules
{
    public class Actions
    {
        public Actions()
        {
            key = "HIDE";
            attribute_name = "";
            value = "";
        }

        public string key  { get; set; }

        public string field_id { get; set; }

        public string attribute_name { get; set; }

        public string formula { get; set; }

        public string value { get; set; }
    }
}
