using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NoticeRepo : IRepository<Notice, int>
    {
        TWDatabaseEntities db;
        public NoticeRepo(TWDatabaseEntities db)
        {
            this.db = db;
        }
        public void Add(Notice e)
        {
                db.Notices.Add(e);
                db.SaveChanges();
        }

        public void Delete(Notice e)
        {
            var i = db.Notices.FirstOrDefault(en => en.id == e.id);
            db.Notices.Remove(i);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var i = db.Notices.FirstOrDefault(e => e.id == id);
            db.Notices.Remove(i);
            db.SaveChanges();
        }

        /* public void Delete(int id)
         {
             
         }*/

        public void Edit(Notice e)
        {
            var i = db.Notices.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(i).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        /*  public List<Notice> GetAllNotices()
          {
              return db.Notices.ToList();
          }*/

        public List<Notice> Get()
       {
           return db.Notices.ToList();
        }

        public Notice Get(int id)
        {
            return db.Notices.FirstOrDefault(e => e.id == id);
        }
    }
}
