using BEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class NoticeService
    {
     public static List<NoticeModel> Get()
        {
            var config = new MapperConfiguration(c =>
             {
                 c.CreateMap<Notice, NoticeModel>();
             });
            Mapper mapper = new Mapper(config);
            var data = mapper.Map<List<NoticeModel>>(NoticeRepo.Get());
            return data;
        }
       
        public static List<string> GetNames()
        {
            
            var data = NoticeRepo.Get().Select(e => e.notice1).ToList();
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
            NoticeRepo.AddNotice(data);
        }

        public static void DeleteNotice(int id)
        {
            NoticeRepo.DeleteNotice(id);
        }
        public static void  EditNotice(NoticeModel notice)
        {
            var config = new MapperConfiguration(c =>
            
                c.CreateMap<NoticeModel, Notice>());
           
            var mapper = new Mapper(config);
            var data = mapper.Map<Notice>(notice);
            NoticeRepo.EditNotice(data);

        }
    }
}
