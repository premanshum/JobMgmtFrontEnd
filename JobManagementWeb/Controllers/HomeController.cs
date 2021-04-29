using JobManagementWeb.Infrastructure.Interfaces.Services;
using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JobManagementWeb.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly ISessionValues _sessionValues;
        JobVM _jobVM;

		public HomeController(
            ILogger<HomeController> logger,
            ISessionValues sessionValues)
		{
			_logger = logger;
            _sessionValues = sessionValues;

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
            if (ModelState.IsValid)
            {
                HttpContext.Session.Clear();
                _sessionValues.UserId = objUser.UserName.ToString();
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
