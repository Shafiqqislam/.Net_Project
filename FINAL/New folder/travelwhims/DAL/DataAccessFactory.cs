using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static TWDatabaseEntities db;
        static DataAccessFactory()
        {
            db = new TWDatabaseEntities();
        }
        public static IRepository<Notice,int> NoticeDataAccess()
        {
            return new NoticeRepo(db);
        }
        public static IRepository<Manager, int> ManagerDataAccess()
        {
            return new ManagerRepo(db);
        }
        public static IRepository<Package, int> PackageDataAccess()
        {
            return new PackageRepo(db);
        }
        public static IRepository<Rating, int> RatingDataAccess()
        {
            return new RatingRepo(db);
        }
    }
}
