using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models
{
    class Section
    {
        int Id { get; set; }
        string Freq { get; set; }    
        SectionAttributes[] SectionAttributes { get; set; }    
    }
}
