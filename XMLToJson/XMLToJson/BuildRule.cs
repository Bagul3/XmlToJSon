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
        public Statements RuleBuider(string rule, int parentID)
        {
            Statements statement = new Statements();
            string[] testArray;


            if(rule.Contains("#"))
            {
                int bn = 0;
                string wow = "";
            }

            statement.field_id = parentID;
            if (rule.Contains("="))
            {
                statement.Operator = "EQ";
                testArray = rule.Split('=');
                statement.test = testArray[1];
            }
            else if (rule.Contains("!="))
            {
                statement.Operator = "NQ";
                testArray = rule.Split('=');
                statement.test = testArray[1];
            }
            else if (rule.Contains(">="))
            {
                statement.Operator = "GTE";
                testArray = rule.Split('=');
                statement.test = testArray[1];
            }
            else if (rule.Contains("<="))
            {
                statement.Operator = "LTE";
                testArray = rule.Split('=');
                statement.test = testArray[1];
            }
            else if (rule.Contains("<"))
            {
                statement.Operator = "LT";
                testArray = rule.Split('<');
                statement.test = testArray[1];
            }
            else if (rule.Contains(">"))
            {
                statement.Operator = "GT";
                testArray = rule.Split('>');
                statement.test = testArray[1];
            }
                
            return statement;

        }

    }
}
