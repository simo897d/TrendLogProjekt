using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json.Linq;

namespace TrendLogProjekt.Models
{
    public class TrendLogData
    {

        [Key]
        public int Pointid { get; set; }

        public DateTime Timestamp { get; set; }
        public int Value { get; set; }

        JObject 

    }
}
