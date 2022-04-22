using BLL;
using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace travelwhims.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/Notice/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return NoticeService.GetNames();
        }
        [Route("api/Notice/All")]
        [HttpGet]
       
        public List<NoticeModel> GetAll()
        {
            return NoticeService.Get();
        }
        [Route("api/notice/add")]
     [HttpPost]
     public void Add(NoticeModel s)
        {
            NoticeService.Add(s);
        }
        [HttpGet]
        [Route("api/notice/delete/{id}")]
        public void Delete(int id)
        {
            NoticeService.Delete(id);

        }
        [Route("api/notice/Edit/{id}")]
        [HttpPost]
        public void Edit(NoticeModel i)
        {
            NoticeService.Edit(i);
        }
        [Route("api/manager/Names")]
        [HttpGet]
        public List<string> GetName()
        {
            return ManagerService.GetName();
        }

        [Route("api/manager/All")]
        [HttpGet]
      
        public List<ManagerModel> Get()
        {
            return ManagerService.Get();
        }

        [HttpGet]
       
        [Route("api/manager/delete/{id}")]
        public void DeleteManager(int id)
        {
            ManagerService.DeleteManager(id);

        }

        [Route("api/manager/Edit/{id}")]
        [HttpPost]
      
        public void Edit(ManagerModel i)
        {
            ManagerService.Edit(i);
        }

        [Route("api/manager/add")]
        [HttpPost]
        public void Add(ManagerModel e)
        {
            ManagerService.Add(e);
        }
        [Route("api/package/All")]
        [HttpGet]

        public List<PackageModel> GetPackage()
        {
            return PackageService.Get();
        }

        [HttpGet]

        [Route("api/package/delete/{id}")]
        public void DeletePackage(int id)
        {
            PackageService.DeletePackage(id);

        }
        [Route("api/rating/All")]
        [HttpGet]

        public List<RatingModel> GetRating()
        {
            return RatingService.Get();
        }

        [HttpGet]

        [Route("api/rating/delete/{id}")]
        public void DeleteRating(int id)
        {
            RatingService.DeleteRating(id);

        }
    }
}
