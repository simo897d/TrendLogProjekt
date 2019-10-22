using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrendLogProjekt.Models;
using TrendLogProjekt.Data;
using Microsoft.EntityFrameworkCore;

namespace TrendLogProjekt.Controllers
{
    public class HomeController : Controller {
        private readonly DataContext db;
        public HomeController(DataContext _db){
            db = _db;
            }
        public IActionResult Index() 
        {
            
                List<TopAuthor> topAuthors = new List<TopAuthor>();
                foreach(TopAuthor ta in db.topAuthors) {
                topAuthors.Add(ta);                  
                };
            List<BandwithReports> bandwithReports = new List<BandwithReports>();
            foreach(BandwithReports br in db.bandwithReports) {
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
