using JobManagementWeb.Common;
using JobManagementWeb.Infrastructure.Interfaces.Services;
using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace JobManagementWeb.Controllers
{

	public class ServiceCenterController : BaseController
	{
		private readonly ILogger<HomeController> _logger;
		private readonly ISessionValues _sessionValues;
		JobVM _jobVM;
		ServiceCenterVM _serviceCenterVM;

		public ServiceCenterController(
			ILogger<HomeController> logger,
			ISessionValues sessionValues)
		{
			_logger = logger;
			_sessionValues = sessionValues;

		}

		
		public IActionResult Index()
        {
			_serviceCenterVM = new ServiceCenterVM();
            return View(_serviceCenterVM);
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

			jobVM = GetJobs().FirstOrDefault(x => x.CustomerPhone.Contains(searchString) || x.CustomerName.ToLower().Contains(searchString.ToLower())); ;

			return jobVM;
		}

	}
}