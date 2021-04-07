using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace JobManagementWeb.Controllers
{
	public class HomeController : BaseController
	{
		private readonly ILogger<HomeController> _logger;

		JobVM _jobVM;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Index()
		{
			HomePageVM homePageVM = new HomePageVM
			{
				//Jobs = GetJobs()
			};

			if(ViewBag.Job != null)
			{
				homePageVM.Jobs.Add(ViewBag.Job);
			}

			//homePageVM.Job = GetJobs().FirstOrDefault();

			return View("Index", homePageVM);
		}

		[HttpPost]
		public string Create(JobVM jobVM)
		{
			_jobVM = new JobVM
			{
				CustomerName = jobVM.CustomerName,
				CustomerPhone = jobVM.CustomerPhone,
				ServiceType = jobVM.ServiceType
			};
			ViewBag.Job = _jobVM;
			return "All is well";
		}

		[HttpPost]
		public JobVM Search(string searchString)
		{
			JobVM jobVM = null;
			if (searchString == null)
			{
				return jobVM;
			}

			//jobVM = GetJobs().FirstOrDefault(x => x.CustomerPhone.Contains(searchString) || x.CustomerName.ToLower().Contains(searchString.ToLower())); ;

			return jobVM;
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
