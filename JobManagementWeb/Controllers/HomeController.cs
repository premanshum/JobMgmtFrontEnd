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
            var loginURL = "http://localhost:55000/api/authenticate/login";
            if (ModelState.IsValid)
            {
                using (HttpClient client = new HttpClient())
                {
                    var loginModel = new { Username = "jobadmin1", Password = "Welcome@123" };
                    var encodedContent = new StringContent(JsonConvert.SerializeObject(loginModel), UnicodeEncoding.UTF8, "application/json");
                    HttpResponseMessage response = client.PostAsync(loginURL, encodedContent).Result;
                    string responseBody = response.Content.ReadAsStringAsync().Result;
                }

                    //HttpContext.Session.Clear();
                    //_sessionValues.UserId = objUser.UserName.ToString();
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
