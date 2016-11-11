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

        string key  { get; set; }

        string field_id { get; set; }

        string attribute_name { get; set; }

        string formula { get; set; }

        string value { get; set; }
    }
}
