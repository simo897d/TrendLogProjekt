using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrendLogProjekt.Models
{
    public class Channel
    {
        [Key]
        public int channel_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime timezone { get; set; }
        public int lifetime { get; set; }
        public int latitude { get; set; }
        public int longtitude { get; set; }
        public int elevation { get; set; }
        public AlarmSettings alarmsettings { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public int maxsize { get; set; }
        public int pcount { get; set; }

        public Feeds[] feeds { get; set; }
    }
}
