using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToJson
{
    public class ReferenceList
    {
        public static Dictionary<int, string> reference = new Dictionary<int,string>();

        public static int GetReferenceID(string sectionName)
        {
            return reference.Where(x => reference.Values.Any(d => d.Contains(sectionName))).Select(x => x.Key).First();
        }
    }
}
