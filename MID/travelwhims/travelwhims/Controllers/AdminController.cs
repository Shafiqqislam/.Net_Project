using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using travelwhims.Models;
using travelwhims.Models.TWdatabase;
using System.Collections;
using System.Dynamic;
using System.Web.Routing;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Web.Security;
using travelwhims.Auth;


namespace travelwhims.Controllers
{
   
    public class AdminController : Controller
    {
        

        TWDatabaseEntities Context = new TWDatabaseEntities();
        // GET: Admin
        [Authorize]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data = (from u in db.Users
                        where u.u_password.Equals(user.u_password) &&
                        u.u_username.Equals(user.u_username)
                        select u).FirstOrDefault();
            if (data != null)
            {
                FormsAuthentication.SetAuthCookie(data.u_username, false);
                Session["role"] = data.u_type;
                /*Session["Username"] = data.u_username;
                  Session["UserType"] = data.u_type;*/

                if (data.u_type == "admin")
                {
                    return RedirectToAction("Home", "Admin");
                }
                if (data.u_type == "customer")
                {
                    return RedirectToAction("Home", "Customer");
                }
                if (data.u_type == "agency")
                {
                    return RedirectToAction("Home", "Travelagency");
                }
                if (data.u_type == "manager")
                {
                    return RedirectToAction("Home", "Manager");
                }
            }

            TempData["msg"] = "Invalid Credentials";
            return RedirectToAction("Login");

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
        [Authorize]
        public ActionResult ViewManager()

        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data = db.Managers.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult CreateManager()

        {
            return View();
        }
        [HttpPost]
        public ActionResult ViewManager(string searchtext)
        {
            var managers = Context.Managers.Where(x => x.m_name.Contains(searchtext)).ToList();
            return View(managers);
        }
        [HttpPost]
        public ActionResult CreateManager(Manager m)

        {
            if (ModelState.IsValid)
            {
                TWDatabaseEntities db = new TWDatabaseEntities();
                db.Managers.Add(m);
                db.SaveChanges();
                TempData["AlertMessage"] = "Manager Added successfully";
                return RedirectToAction("ViewManager");
            }
            return View(m);
        }
        public ActionResult DeleteManager(int id)

        {
            var manager = Context.Managers.FirstOrDefault(e => e.id == id);
            return View(manager);
        }

        [HttpPost]
        [ActionName("DeleteManager")]
        public ActionResult DeleteManagerU(int id)
        {
            var manager = Context.Managers.FirstOrDefault(e => e.id == id );
            Context.Managers.Remove(manager);
            Context.SaveChanges();
            TempData["AlertMessage"] = "Manager Delete successfully";
            return RedirectToAction("ViewManager");
        }
        public ActionResult EditManager(int id)
        {
            var manager = Context.Managers.FirstOrDefault(e => e.id == id);
            return View(manager);
        }
        [HttpPost]
        public ActionResult EditManager(Manager m)
        {
            var manager = Context.Managers.FirstOrDefault(e => e.id == m.id);
            Context.Entry(manager).CurrentValues.SetValues(m);
            Context.SaveChanges();
            TempData["AlertMessage"] = "Manager Edit successfully";
            return RedirectToAction("ViewManager");
        }
        [AdminAccess]
        public ActionResult ViewUser()
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data = db.Users.ToList();
            return View(data);
        }

        public ActionResult DeleteUser(int id)

        {
            var user = Context.Users.FirstOrDefault(e => e.id == id);
            return View(user);
        }

        [HttpPost]
        [ActionName("DeleteUser")]
        public ActionResult DeleteUserU(int id)
        {
            var user = Context.Users.FirstOrDefault(e => e.id == id);
            Context.Users.Remove(user);
            Context.SaveChanges();
            return RedirectToAction("ViewUser");
        }
        public ActionResult EditUser(int id)
        {
            var user = Context.Users.FirstOrDefault(e => e.id == id);
            return View(user);
        }
        [HttpPost]
        public ActionResult EditUser(User u)
        {
            var user = Context.Users.FirstOrDefault(e => e.id == u.id);
            Context.Entry(user).CurrentValues.SetValues(u);
            Context.SaveChanges();
            return RedirectToAction("ViewUser");
        }
        [HttpPost]
        public ActionResult ViewUser(string searchname)
        {
            var users = Context.Users.Where(x => x.u_username.Contains(searchname)).ToList();
            return View(users);
        }
        public ActionResult ViewPackage()
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var data = db.Packages.ToList();
            return View(data);
        }
        public ActionResult ViewNotice()
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var notice = db.Notices.ToList();
            return View(notice);
        }
        [HttpPost]
        public ActionResult ViewNotice(string status, int id)
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            //var data = db.Notices.ToList();
            var oldp = db.Notices.FirstOrDefault(e => e.id == id);
            oldp.status = status;
            db.SaveChanges();
            return RedirectToAction("ViewNotice");
        }

        TWDatabaseEntities dbobj = new TWDatabaseEntities();
        public ActionResult CreateNotice()

        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNotice(Notice n)

        {
            if (ModelState.IsValid)
            {
                Notice obj = new Notice();
                obj.id = n.id;
                obj.notice1 = n.notice1;
                obj.user_type = n.user_type;
                obj.status = n.status;
                obj.datet = DateTime.Now;
                dbobj.Notices.Add(obj);
                dbobj.SaveChanges();
                TempData["AlertMessage"] = "Notice Added successfully";
                return RedirectToAction("ViewNotice");
            }
            return View(n);
        }
        public ActionResult EditNotice(int id)
        {
            var notice = Context.Notices.FirstOrDefault(e => e.id == id);
            return View(notice);
        }
        [HttpPost]
        public ActionResult EditNotice(Notice n)
        {
            var notice = Context.Notices.FirstOrDefault(e => e.id == n.id);
            Context.Entry(notice).CurrentValues.SetValues(n);
            Context.SaveChanges();
            TempData["AlertMessage"] = "Notice update successfully";
            return RedirectToAction("ViewNotice");
        }
        public ActionResult DeleteNotice(int id)

        {
            var notice = Context.Notices.FirstOrDefault(e => e.id == id);
            return View(notice);
        }

        [HttpPost]
        [ActionName("DeleteNotice")]
        public ActionResult DeleteNoticeU(int id)
        {
            var notice = Context.Notices.FirstOrDefault(e => e.id == id);
            Context.Notices.Remove(notice);
            Context.SaveChanges();
            TempData["AlertMessage"] = "Notice delete successfully";
            return RedirectToAction("ViewNotice");
        }
       
        public ActionResult ViewRating()
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            var rating = db.Ratings.ToList();
            return View(rating);
        }
        public ActionResult DeleteRating(int id)

        {
            var rating = Context.Ratings.FirstOrDefault(e => e.id == id);
            return View(rating);
        }

        [HttpPost]
        [ActionName("DeleteRating")]
        public ActionResult DeleteRatingU(int id)
        {
            var rating = Context.Ratings.FirstOrDefault(e => e.id == id);
            Context.Ratings.Remove(rating);
            Context.SaveChanges();
            return RedirectToAction("ViewRating");
        }
        public ActionResult EditRating(int id)
        {
            var rating = Context.Ratings.FirstOrDefault(e => e.id == id);
            return View(rating);
        }
        [HttpPost]
        public ActionResult EditRating(Rating r)
        {
            var rating = Context.Ratings.FirstOrDefault(e => e.id == r.id);
            Context.Entry(rating).CurrentValues.SetValues(r);
            Context.SaveChanges();
            return RedirectToAction("ViewRating");
        }
        public ActionResult Report()
        {
            
            bager();
            return View();
        }
        public void bager()
        {
            TWDatabaseEntities db = new TWDatabaseEntities();
            ViewBag.displaymanager = db.Managers.ToList();
            ViewBag.Count = db.Managers.Count();
        }
       
    }
}