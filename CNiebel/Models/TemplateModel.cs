using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNiebel.Models
{
    public class TemplateModel
    {
        public TemplateModel()
        { }

        public TemplateModel(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}