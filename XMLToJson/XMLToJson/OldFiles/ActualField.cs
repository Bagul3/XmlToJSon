using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models
{
    public class ActualField
    {
        public ActualField(string title, string type)
        {
            this.title = title;
            this.type = type;
        }

        public string title { get; set; }

        public string type { get; set; }

        public ActualFieldAttributes attributes { get; set; }
    }
}
