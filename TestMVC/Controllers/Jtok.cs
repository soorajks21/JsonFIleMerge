using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Controllers
{
   
        public class Result
    {
        [JsonProperty("value")]
        public int Value { get; set; }
        [JsonProperty("characters")]
        public string Characters { get; set; }
        [JsonProperty("data")]
        public List<Data> Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("value")]
        public int Value { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
    }
    
}