using JobManagementWeb.Infrastructure.Entities;
using JobManagementWeb.Infrastructure.Interfaces.Services;
using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace JobManagementWeb.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly ISessionValues _sessionValues;
        private readonly IUserService _UserService;

		public HomeController(
            ILogger<HomeController> logger,
            ISessionValues sessionValues,
            IUserService userService)
		{
			_logger = logger;
            _sessionValues = sessionValues;
            _UserService = userService;
        }

		[ActionName("Index")]
		public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
		}

        /// <summary>
        /// Index
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(UserProfile objUser)
        {
            var modelData = objUser != null ? "true" : "false";
            var loginURL = "http://localhost:55000/api/authenticate/login";
            if (ModelState.IsValid)
            {
                var responseBody = _UserService.Login(new Request<UserProfile>
                {
                    Url = loginURL,
                    UserId = objUser.UserName,
                    RequestObject = objUser
                });

                HttpContext.Session.SetString("UserId", objUser.UserName);
                if (objUser.UserName.ToLower().Equals("ad"))
                {
                    return RedirectToAction("Index", "Admin");
                }
                return RedirectToAction("Index", "Dashboard");
            }
            return View(objUser);
        }

        public IActionResult Privacy()
		{
			return View();
		}

	}
}
