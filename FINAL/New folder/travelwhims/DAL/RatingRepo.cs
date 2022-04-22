using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RatingRepo : IRepository<Rating, int>
    {
        TWDatabaseEntities db;
        public RatingRepo(TWDatabaseEntities db)
        {
            this.db = db;
        }
        public void Add(Rating e)
        {
            throw new NotImplementedException();
        }

        public void Delete(Rating e)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            var i = db.Ratings.FirstOrDefault(e => e.id == id);
            db.Ratings.Remove(i);
            db.SaveChanges();
        }

        public void Edit(Rating e)
        {
            throw new NotImplementedException();
        }

        public List<Rating> Get()
        {
            return db.Ratings.ToList();
        }

        public Rating Get(int id)
        {
            return db.Ratings.FirstOrDefault(e => e.id == id);
        }
    }
}
