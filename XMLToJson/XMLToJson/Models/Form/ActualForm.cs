using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson.Models
{
    public class ActualForm
    {
        public ActualForm()
        {
            id = 0;
            order = 0;
        }

        public int id { get; set; }
        public int order { get; set; }
    }
}
