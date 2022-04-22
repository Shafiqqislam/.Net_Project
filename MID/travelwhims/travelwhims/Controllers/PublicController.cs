using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using travelwhims.Models.TWdatabase;

namespace travelwhims.Controllers
{
    public class PublicController : Controller
    {
        // GET: Public

        [HttpGet]
        public ActionResult Index()
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data = (from p in db.Packages
                        where p.pac_status != "inactive"
                        select p).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Packages()
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data = (from p in db.Packages
                        where p.pac_status != "inactive"
                        select p).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Package(int id)
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data = (from p in db.Packages 
                        where p.id == id 
                        select p).FirstOrDefault();

            return View(data);
        }

        public ActionResult TravelAgency(int id)
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data = (from ta in db.TravelAgencies
                        where ta.id == id
                        select ta).FirstOrDefault();

            return View(data);
        }

        public ActionResult TravelAgencies()
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data1 = (from ta in db.TravelAgencies
                         where ta.ta_rating != "notrated"
                        orderby ta.ta_rating descending
                        select ta).ToList();
            var data2 = (from ta in db.TravelAgencies
                         where ta.ta_rating == "notrated"
                         select ta).ToList();
            data1.AddRange(data2);

            return View(data1);
        }


       
    }
}