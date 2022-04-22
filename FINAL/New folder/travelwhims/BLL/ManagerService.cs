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
   public class ManagerService
    {
        public static List<ManagerModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Manager, ManagerModel>();
               
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.ManagerDataAccess();
            var data = mapper.Map<List<ManagerModel>>(da.Get());
            return data;
        }
        public static void DeleteManager(int id)
        {
            DataAccessFactory.ManagerDataAccess().Delete(id);
        }

        public static void Edit(ManagerModel i)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Manager, ManagerModel>();
                c.CreateMap<ManagerModel, Manager>();
              
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Manager>(i);

            DataAccessFactory.ManagerDataAccess().Edit(data);

        }


        public static List<string> GetName()
        {
            var data = DataAccessFactory.ManagerDataAccess().Get().Select(e => e.m_name).ToList();
            return data;
        }
        /*public static void Add(ManagerModel i)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ManagerModel, Manager>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Manager>(i);
            DataAccessFactory.ManagerDataAccess().Add(data);
        }*/
        public static void Add(ManagerModel e)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ManagerModel, Manager>());
            var mapper = new Mapper(config);
            var data = mapper.Map<Manager>(e);
            DataAccessFactory.ManagerDataAccess().Add(data);

        }
    }
}
