using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PackageRepo : IRepository<Package, int>
    {
        TWDatabaseEntities db;
        public PackageRepo(TWDatabaseEntities db)
        {
            this.db = db;
        }
        public void Add(Package e)
        {
            throw new NotImplementedException();
        }

        public void Delete(Package e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var i = db.Packages.FirstOrDefault(e => e.id == id);
            db.Packages.Remove(i);
            db.SaveChanges();
        }

        public void Edit(Package e)
        {
            throw new NotImplementedException();
        }

        public List<Package> Get()
        {
            return db.Packages.ToList();
        }

        public Package Get(int id)
        {
            return db.Packages.FirstOrDefault(e => e.id == id);
        }
    }
}
