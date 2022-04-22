using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace travelwhims.Auth
{
    [AttributeUsage(AttributeTargets.Class |AttributeTargets.Method)]
    public class AdminAccess : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            var authenticated = base.AuthorizeCore(httpContext);
            if (!authenticated)
            {
                return false;
            }
            
                if (httpContext.Session["role"].ToString().Equals("admin"))
                {
                    return true;
                }
                return false;
            }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Redirect("/Admin/Login");
        }
        // return base.AuthorizeCore(httpContext);

    }
}