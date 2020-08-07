using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        List<Result> obj = new List<Result>();
        List<Result> obj2 = new List<Result>();
        List<Result> result = new List<Result>();

      
        public ActionResult Index()
        {
            return RedirectToAction("UploadFile", "Home");
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //[HttpPost]
        //public ActionResult ContactForm(JsonModel membervalues, string submitButton)
        //{


        //    return View();
        //}
        [HttpPost]
        public ActionResult SortByValue(JsonModel membervalues)
        {
            Merge(membervalues);
            var sortByValue = obj.OrderBy(x => x.Data.Min(s => s.Value));
            result = sortByValue.ToList<Result>();
            return View(result);
        }

        [HttpPost]
        public ActionResult SortByLocation(JsonModel membervalues)
        {
            Merge(membervalues);
            var sortByLocation = obj.OrderBy(x => x.Data.Min(s => s.Location));
            result = sortByLocation.ToList<Result>();
            return View(result);
        }


        private void Merge(JsonModel membervalues)
        {
            JToken jtok1 = "";
            JToken jtok2 = "";

            string str = (new StreamReader(membervalues.json1.InputStream)).ReadToEnd();
            obj = JsonConvert.DeserializeObject<List<Result>>(str);
            string str2 = (new StreamReader(membervalues.json2.InputStream)).ReadToEnd();
            obj2 = JsonConvert.DeserializeObject<List<Result>>(str2);
            obj.AddRange(obj2);

        }

      
    
    }
}