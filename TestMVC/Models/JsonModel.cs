using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class JsonModel
    {
        [DisplayName("json1")]
        public HttpPostedFileBase json1 { get; set; }
        [DisplayName("json2")]
        public HttpPostedFileBase json2 { get; set; }
    }
}