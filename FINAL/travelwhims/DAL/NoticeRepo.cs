using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NoticeRepo
    {
        static TWDatabaseEntities db;
        static NoticeRepo()
        {
            db = new TWDatabaseEntities();
        }
        public static List<Notice> Get()
        {
            return db.Notices.ToList();
        }
        public static Notice Get(int id)
        {
            return db.Notices.FirstOrDefault(e => e.id == id);
        }
        public static List<Notice> GetSearchNotices(string search)
        {
            var list = (from p in db.Notices
                        where p.notice1.Contains(search)
                        select p).ToList();
            return list;
        }
        public static void EditNotice(Notice s)
        {
            var ds = db.Notices.FirstOrDefault(e => e.id == s.id);
            db.Entry(ds).CurrentValues.SetValues(s);
            db.SaveChanges();
        }
       
        public static void DeleteNotice(int id)
        {
            var u = db.Notices.FirstOrDefault(e => e.id == id);
            db.Notices.Remove(u);
            db.SaveChanges();

        }
        public static void AddNotice(Notice s)
        {
            db.Notices.Add(s);
            db.SaveChanges();
         
        }

    }
}
