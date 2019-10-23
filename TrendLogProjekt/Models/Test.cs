//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

//public class Rootobject
//{
//    public Channel channel { get; set; }
//}

//public class Channel
//{
//    public string channel_id { get; set; }
//    public string name { get; set; }
//    public string description { get; set; }
//    public string timezone { get; set; }
//    public string lifetime { get; set; }
//    public string latitude { get; set; }
//    public string longitude { get; set; }
//    public string elevation { get; set; }
//    public Alarmsettings alarmsettings { get; set; }
//    public string created { get; set; }
//    public string updated { get; set; }
//    public string maxsize { get; set; }
//    public string pcount { get; set; }
//    public Feed[] feeds { get; set; }
//}

//public class Alarmsettings
//{
//    [Key]
//    public string email { get; set; }
//}

//public class Feed
//{
//    public string feed_id { get; set; }
//    public string name { get; set; }
//    public string label { get; set; }
//    public string scale { get; set; }
//    public string alarm { get; set; }
//    public string enable_alarm { get; set; }
//    public string alarm_settings { get; set; }
//    public Point[] points { get; set; }
//}

//public class Point
//{
//    public string pointid { get; set; }
//    public string timestamp { get; set; }
//    public string value { get; set; }
//}

