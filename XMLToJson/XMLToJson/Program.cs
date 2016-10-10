using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using XMLEngine;
using XMLToJson.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace XMLToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLParser();
        }

        public static void XMLParser()
        {            
            var serializer = new XmlSerializer(typeof(QAConfig));
            QAConfig form;
            using (var reader = File.OpenRead(@"C:\Users\ConorShannon\Contract-Work\XmlToJSon\FQAS\FQAS Inspection Checklist.xml"))
            {
                form = (QAConfig)serializer.Deserialize(reader);
            }
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = JsonConvert.SerializeObject(form.Form, Newtonsoft.Json.Formatting.Indented);
            JToken tokenJson = JToken.Parse(json.Trim());
            json = Regex.Unescape(json);
            StringBuilder formJson = new StringBuilder("[");
            formJson.Append(GetForm(form.Form));
            formJson.Append(GetSections(form.Form));
            formJson.Append("]");
        }

        public static StringBuilder GetSections(Form form)
        {
            StringBuilder buildSections = new StringBuilder("");
            Section last = form.sections.Last();
            foreach(Section section in form.sections)
            {
                ActualSection actualSection = new ActualSection(section);

                if (!section.Equals(last))
                {
                    buildSections.Append(Regex.Unescape(JsonConvert.SerializeObject(actualSection)) + ",");
                    FieldAttributes lastField = new FieldAttributes();
                    if (section.field.Count != 0)
                    {
                        lastField = section.field.Last();
                    }

                    foreach (FieldAttributes field in section.field)
                    {
                        if(!field.Equals(lastField))
                        {
                            buildSections.Append(Regex.Unescape(JsonConvert.SerializeObject(field)) + ",");
                        }
                        else
                        {
                            buildSections.Append(Regex.Unescape(JsonConvert.SerializeObject(field)) + ",");
                        }
                        
                    }
                }
                else
                {
                    buildSections.Append(Regex.Unescape(JsonConvert.SerializeObject(actualSection)));
                    FieldAttributes lastField = new FieldAttributes();
                    if (section.field.Count != 0)
                    {
                        lastField = section.field.Last();
                    }
                   
                    foreach (FieldAttributes field in section.field)
                    {
                        if (!field.Equals(lastField))
                        {
                            buildSections.Append(Regex.Unescape(JsonConvert.SerializeObject(field)) + ",");
                        }
                        else
                        {
                            buildSections.Append(Regex.Unescape(JsonConvert.SerializeObject(field)));
                        }

                    }
                }
            }
            return buildSections;
        }

        public static StringBuilder GetForm(Form form)
        {
            ActualForm formbj = new ActualForm();
            StringBuilder builderForm = new StringBuilder("");
            builderForm.Append(Regex.Unescape(JsonConvert.SerializeObject(formbj)));
            builderForm.Append(",");
            return builderForm;
        }

        public static StringBuilder GetField(FieldAttributes field)
        {
            StringBuilder buildField = new StringBuilder("");
            ActualField actualField = new ActualField(field.Title,field.Type);
            ActualFieldAttributes attributes = new ActualFieldAttributes(field);
            actualField.attributes = attributes;
            buildField.Append(Regex.Unescape(JsonConvert.SerializeObject(actualField)));
            return buildField;
        }

        
    }
}
