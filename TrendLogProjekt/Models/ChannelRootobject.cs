using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrendLogProjekt.Models {
    public class ChannelRootobject {
        [Key]
        public Channel channel { get; set; }
    }
    public class Channel {
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
    public class Feeds {
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
    public class Points {
        [Key]
        public int pointid { get; set; }

        public DateTime timestamp { get; set; }
        public int value { get; set; }
    }
    public class AlarmSettings {
        [Key]
        public string email { get; set; }

    }
}
