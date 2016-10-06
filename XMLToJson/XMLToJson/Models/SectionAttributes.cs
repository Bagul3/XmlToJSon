using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models
{
    class SectionAttributes
    {
        string Group { get; set; }
        string Name { get; set; }
        string Mandatory { get; set; }
        string Type { get; set; }
        string Default { get; set; }
        string[] Options { get; set; }
        string Colour { get; set; }
    }
}
