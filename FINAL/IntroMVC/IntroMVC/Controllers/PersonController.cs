using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroMVC.Models;

namespace IntroMVC.Controllers
{
    public class PersonController : Controller
    {
      
        public ActionResult  Create()
        {
            return View();
        }
        public ActionResult Home()
        {
            /*ViewBag.Name = "Tanvir mOta";
            ViewBag.Id = 123;
            ViewBag.Dob = DateTime.Now;*/

            Person p = new Person();
            p.Name = "Tanvir diet";
            p.Id = 123;
            p.Dob = DateTime.Now;
            return View(p);
        }
        public ActionResult  List()
        {
            /*string[] names = { "anhdjd", "jsjshjsj", "jwdgwgd", "hwdgqfydq" };
            ViewBag.Names = names;*/

            List<Person> persons = new List<Person>();
            for (int i = 0; i < 100; i++) {
                var p = new Person
                {
                    Id = i + 1,
                    Name = "Person " + (i + 1),
                    Dob = DateTime.Now
                };
                persons.Add(p);
            }
            return View(persons);
        }
    }
}