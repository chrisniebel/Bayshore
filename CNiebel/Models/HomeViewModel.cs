using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CNiebel.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            this.Templates = new List<TemplateModel>();
        }
        public string ParsedText { get; internal set; }
        public List<TemplateModel> Templates { get; private set; }
        public string InputText { get;  set; }
    }
}