using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using BLL.BEnt;

namespace BLL
{
    public class NoticeService
    {
        public static List<NoticeModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                // c.CreateMap<Payment, PaymentModel>();
                //c.CreateMap<Comment, CommentModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.NoticeDataAccess();
            var data = mapper.Map<List<NoticeModel>>(da.Get());
            return data;
        }
        public static void Delete(int id)
        {
            DataAccessFactory.NoticeDataAccess().Delete(id);
        }
        public static List<string> GetNames()
        {
            
            var data = DataAccessFactory.NoticeDataAccess().Get().Select(e => e.notice1).ToList();
            return data;
        }

        public static void Add(NoticeModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NoticeModel, Notice>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Notice>(s);
            DataAccessFactory.NoticeDataAccess().Add(data);
        }
        public static void Edit(NoticeModel d)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<NoticeModel, Notice>();
              
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Notice>(d);

            DataAccessFactory.NoticeDataAccess().Edit(data);

        }
    }
}
