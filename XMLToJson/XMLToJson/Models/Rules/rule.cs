using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models.Rules
{
    public class Rule
    {
        public List<Statements> statements { get; set; }

        public List<Actions> actions { get; set; }
    }
}
