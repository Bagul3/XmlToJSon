using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLToJson.Models.Misc
{
    public class Metadata
    {
        public Metadata(string key, string value)
        {
            metadata = new KeyValuePair<string, string>(key, value);
        }
        
        public KeyValuePair<string,string> metadata { get; set; }
    }
}
