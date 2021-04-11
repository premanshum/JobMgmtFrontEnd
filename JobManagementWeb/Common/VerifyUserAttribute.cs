using JobManagementWeb.Infrastructure.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace JobManagementWeb.Common
{
    public class VerifyUserAttribute : TypeFilterAttribute, IAuthorizationFilter
    {

        public VerifyUserAttribute() :  base(typeof(VerifyUserAttribute))
        {
        }

        public void OnAuthorization(AuthorizationFilterContext filterContext)
        {
            if (string.IsNullOrWhiteSpace(filterContext.HttpContext.Session.GetString("UserId")))
            {
                filterContext.Result = new UnauthorizedResult();
            }
        }
    }
}
