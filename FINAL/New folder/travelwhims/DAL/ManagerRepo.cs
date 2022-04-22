using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerRepo : IRepository<Manager, int>
    {
        TWDatabaseEntities db;
        public ManagerRepo(TWDatabaseEntities db)
        {
            this.db = db;
        }

        public void Add(Manager e)
         {
             db.Managers.Add(e);
             db.SaveChanges();
         }
       

        public void Delete(Manager e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var i = db.Managers.FirstOrDefault(e => e.id == id);
            db.Managers.Remove(i);
            db.SaveChanges();
        }

        public void Edit(Manager e)
        {
            var i = db.Managers.FirstOrDefault(en => en.id == e.id);
            db.Entry(i).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Manager> Get()
        {
            return db.Managers.ToList();
        }

        public Manager Get(int id)
        {
            return db.Managers.FirstOrDefault(e => e.id == id);
        }
    }
}
