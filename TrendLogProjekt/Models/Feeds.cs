using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TrendLogProjekt.Models;

namespace TrendLogProjekt.Models
{
    public class Feeds
    {
        [Key]
        public int feed_id { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public int scale { get; set; }
        public int alarm { get; set; }
        public int enable_alarm { get; set; }
        public string alarm_settings { get; set; }
        public Points[] points { get; set; }
    }
}