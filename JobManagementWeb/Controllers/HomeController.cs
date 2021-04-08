using JobManagementWeb.Infrastructure;
using JobManagementWeb.Infrastructure.Interfaces.Services;
using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace JobManagementWeb.Controllers
{
	public class HomeController : BaseController
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
                return RedirectToAction("Index", "ServiceCenter");
            }
            return View(objUser);
        }

        public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
