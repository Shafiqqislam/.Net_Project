using AutoMapper;
using BLL.BEnt;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class PackageService
    {
        public static List<PackageModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Package, PackageModel>();
              
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.PackageDataAccess();
            var data = mapper.Map<List<PackageModel>>(da.Get());
            return data;
        }
        public static void DeletePackage(int id)
        {
            DataAccessFactory.PackageDataAccess().Delete(id);
        }
    }
}
