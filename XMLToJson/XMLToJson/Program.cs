using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using XMLToJson.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using XMLToJson.Models.IndividualFields.Actual;
using XMLToJson.Models.IndividualFields;
using XMLToJson.Models.Rules;

namespace XMLToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            TOJSON();
        }

        public static void TOJSON()
        {            
            var serializer = new XmlSerializer(typeof(QAConfig));
            QAConfig form;
            using (var reader = File.OpenRead(@"C:\Users\Conor\Documents\DevWork\ChrisWork\XmlToJSon\FQACS\FQACS Inspection.xml"))
            {
                form = (QAConfig)serializer.Deserialize(reader);
            }
            
            JavaScriptSerializer js = new JavaScriptSerializer();
            string json = JsonConvert.SerializeObject(form.Form, Formatting.Indented);
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
                actualSection.attributes = section.attributes;

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
                        switch (field.name)
                        {
                            case "varchar":
                                ActualTextField textField = new ActualTextField(field);
                                ActualTextFieldAttributes attributes = new ActualTextFieldAttributes(field);
                                textField.attributes = attributes;
                                textField.title = "Text Field";
                                textField.attributes.mailmerge = textField.caption + " " + textField.id;
                                
                                buildSections.Append(NotLastFieldItem_MapFieldItem(textField, lastField));
                                break;
                            case "int":
                                ActualNumberField number = new ActualNumberField(field);
                                ActualNumberFieldAttributes numberAttributes = new ActualNumberFieldAttributes(field);
                                number.attributes = numberAttributes;
                                number.name = "number";
                                number.title = "Number Field";
                                number.attributes.mailmerge = number.caption + " " + number.id;
                                buildSections.Append(NotLastFieldItem_MapFieldItem(number, lastField));
                                break;
                            case "list":
                                ActualListField list = new ActualListField(field);
                                ActualListFieldAttributes listattributes = new ActualListFieldAttributes(field);
                                list.attributes = listattributes;
                                list.name = "list";
                                list.title = "Dropdown Field";
                                list.attributes.mailmerge = list.caption + " " + list.id;
                                buildSections.Append(NotLastFieldItem_MapFieldItem(list, lastField));
                                break;
                            case "datetime":
                                ActualDateTimeField date = new ActualDateTimeField(field);
                                ActualDateTimeFieldAttributes dateattributes = new ActualDateTimeFieldAttributes(field);
                                date.attributes = dateattributes;
                                date.name = "datetime";
                                date.title = "Date Field";
                                date.attributes.helpertext = "Please enter a date as dd/mm/yyyy";
                                date.attributes.validregex = "DATE_SYSTEM";
                                date.attributes.example = "25/12/2013";
                                date.attributes.mailmerge = date.caption + " " + date.id;
                                buildSections.Append(NotLastFieldItem_MapFieldItem(date, lastField));
                                break;
                            case "radio":
                                ActualRadioField radio = new ActualRadioField(field);
                                ActualRadioFieldAttributes radioattributes = new ActualRadioFieldAttributes(field);
                                radio.attributes = radioattributes;
                                radio.name = "radio";
                                radio.title = "Radio Button Field";
                                radio.attributes.mailmerge = radio.caption + " " + radio.id;
                                buildSections.Append(NotLastFieldItem_MapFieldItem(radio, lastField));
                                break;
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
                        ActualTextField actualField = new ActualTextField();
                        switch (field.caption)
                        {
                            case "varchar":
                                actualField = new ActualTextField(field);
                                ActualTextFieldAttributes attributes = new ActualTextFieldAttributes(field);
                                actualField.attributes = attributes;
                                if (!field.Equals(lastField))
                                {
                                    buildSections.Append(Regex.Unescape(JsonConvert.SerializeObject(actualField)) + ",");
                                }
                                else
                                {
                                    buildSections.Append(Regex.Unescape(JsonConvert.SerializeObject(actualField)));
                                }
                                break;
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

        public static string UppercaseFirstEach(string s)
        {
            char[] a = s.ToLower().ToCharArray();

            for (int i = 0; i < a.Count(); i++)
            {
                a[i] = i == 0 || a[i - 1] == ' ' ? char.ToUpper(a[i]) : a[i];

            }

            return new string(a);
        }

        private static StringBuilder NotLastFieldItem_MapFieldItem(Object field, Object lastField)
        {
            StringBuilder buildField = new StringBuilder("");
            if (!field.Equals(lastField))
            {
                return buildField.Append(Regex.Unescape(JsonConvert.SerializeObject(field)) + ",");
            }
            else
            {
                return buildField.Append(Regex.Unescape(JsonConvert.SerializeObject(field)) + ",");
            }
        }


    }
}
