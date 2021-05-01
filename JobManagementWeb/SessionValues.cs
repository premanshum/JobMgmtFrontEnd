using JobManagementWeb.Infrastructure.Interfaces.Services;
using Microsoft.AspNetCore.Http;

namespace JobManagementWeb
{
	public class SessionValues : ISessionValues
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public SessionValues(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        /// <summary>
        /// UserId
        /// </summary>
        public string UserId
        {
            get
            {
                return _contextAccessor.HttpContext.Session.GetString("UserId");
            }
            set
            {
                _contextAccessor.HttpContext.Session.SetString("UserId", value);
            }
        }

        /// <summary>
        /// UserId
        /// </summary>
        public string Token
        {
            get
            {
                return _contextAccessor.HttpContext.Session.GetString("Token");
            }
            set
            {
                _contextAccessor.HttpContext.Session.SetString("Token", value);
            }
        }

    }
}
