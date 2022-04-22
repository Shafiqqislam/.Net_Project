using BLL;
using BEL;
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
        public List<NoticeModel> GetAll()
        {
            return NoticeService.Get();
        }

        [Route("api/notice/delete/{id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            NoticeService.DeleteNotice(id);
        }
        [Route("api/notice/add")]
        [HttpPost]
        public void AddNotice(NoticeModel notice)
        {
            NoticeService.Add(notice);
        }
        [Route("api/notice/edit")]
        [HttpPut]
        public void EditNotice(NoticeModel notice)
        {
             NoticeService.EditNotice(notice);
        }
    }
}
