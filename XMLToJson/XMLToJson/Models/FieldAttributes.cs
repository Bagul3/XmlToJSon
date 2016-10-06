using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models
{
    class FieldAttributes
    {
        string Name { get; set; }
        string Type { get; set; }
        string Group { get; set; }
        bool Mandatory { get; set; }
        string Default { get; set; }
        string[] Options { get; set; }
        string Code { get; set; }
        string Required { get; set; }
        string Hide { get; set; }
    }
}
