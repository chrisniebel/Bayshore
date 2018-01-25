using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CNiebel.Models;

namespace CNiebel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HomeViewModel());
        }

        public ActionResult AddKeyValue(HomeViewModel model, string newKey, string newValue)
        {
            model.Templates.Add(new TemplateModel(newKey, newValue));
            return View("Index", model);
        }
        public ActionResult Parse(HomeViewModel model)
        {
            model.ParsedText = ParseTemplate(model);
            return View("Index", model);
        }

        private string ParseTemplate(HomeViewModel model)
        {
            var parsedText = string.IsNullOrEmpty(model.InputText) ? string.Empty : model.InputText;
            foreach (var template in model.Templates)
            {
                var key = "${" + template.Key + "}";
                parsedText = parsedText.Replace(key, template.Value);
            }
            return parsedText;
        }
    }
}