using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLToJson.Models.Rules;

namespace XMLToJson
{
    class BuildRule
    {
        public Statements RuleBuider(string rule)
        {
            Statements statement = new Statements();
            if (rule.Contains("="))
                statement.Operator = "EQ";
            else if (rule.Contains("!="))
                statement.Operator = "NQ";
            else if (rule.Contains(">="))
                statement.Operator = "GTE";
            else if (rule.Contains("<="))
                statement.Operator = "LTE";
            else if (rule.Contains("<"))
                statement.Operator = "LT";
            else if (rule.Contains(">"))
                statement.Operator = "GT";
            GetTest(rule);
            return statement;

        }

        public string GetTest(string rule)
        {
            string[] testArray;
            if (rule.Contains("="))
            {
                testArray = rule.Split('=');
            }
            else if(rule.Contains(">"))
            {
                testArray = rule.Split('>');
            }
            else if(rule.Contains("<"))
            {
                testArray = rule.Split('<');
            }
            return "";
        }

    }
}
