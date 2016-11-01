using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models.Rules
{
    public class Statements
    {
        public Statements()
        {
            field_id++;
            type = "Clause";
        }

        public string type { get; set; }

        public int field_id { get; set; }

        public string Operator { get; set; }

        public string test { get; set; }
    }
}
