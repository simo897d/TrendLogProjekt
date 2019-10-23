using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace TrendLogProjekt.Models
{
    public class Points
    {
        //public TrendLogData(string json) {
        //        JObject jObject = JObject.Parse(json);
        //        JToken jId = jObject["pointid"];
        //    Value = (int)jObject["value"];
        //    Timestamp = (DateTime)jObject["timestamp"];
        //}

        [Key]
        public int pointid { get; set; }

        public DateTime timestamp { get; set; }
        public int value { get; set; }

        

    }
}
