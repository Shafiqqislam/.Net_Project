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
    public class RatingService
    {
        public static List<RatingModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Rating, RatingModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccessFactory.RatingDataAccess();
            var data = mapper.Map<List<RatingModel>>(da.Get());
            return data;
        }
        public static void DeleteRating(int id)
        {
            DataAccessFactory.RatingDataAccess().Delete(id);
        }
       
    }
}
