using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrendLogProjekt.Models;
using TrendLogProjekt.Data;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json.Linq;
using Nancy.Json;
using System.Buffers.Text;
using System.IO;
using Newtonsoft.Json;

namespace TrendLogProjekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;
        public byte[] arr;
        public string converted;
        public HomeController(DataContext _db) {
            db = _db;
        }

        public IActionResult Index() {
            using (WebClient client = new WebClient()) {
                client.Headers["User-Agent"] =
                "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0)";
                arr = client.DownloadData("https://api.trendlog.io/V1/channels/20/feeds/p1_cnt?apikey=GUZ5VO4I39GM");
            }

            var serialiser = new JavaScriptSerializer();
            converted = Encoding.UTF8.GetString(arr);
            ChannelRootobject channels = JsonConvert.DeserializeObject<ChannelRootobject>(converted);

            List <TopAuthor> topAuthors = new List<TopAuthor>();
            foreach (TopAuthor ta in db.topAuthors) {
                topAuthors.Add(ta);
            };
            List<BandwithReports> bandwithReports = new List<BandwithReports>();
            foreach (BandwithReports br in db.bandwithReports) {
                bandwithReports.Add(br);
            }
            IndexModel indexModel = new IndexModel {
                BandWithReports = bandwithReports,
                TopAuthors = topAuthors
            };


            return View(indexModel);
        }
        //public IActionResult Privacy() {
        //    return View();
        //}


           


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
