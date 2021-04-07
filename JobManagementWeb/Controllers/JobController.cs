using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace JobManagementWeb.Controllers
{
    public class JobController : BaseController
	{
		private readonly ILogger<JobController> _logger;
		JobVM _jobVM;

		public IActionResult Index()
        {
            return View();
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

		private List<JobVM> GetJobs()
		{
			List<JobVM> jobs = new List<JobVM>
			{
				new JobVM
				{
					CustomerName = "Yudhi",
					CustomerPhone = "8908903245",
					JobId = "jbasd2313",
					ServiceType = "New"
				},
				new JobVM
				{
					CustomerName = "Bheem",
					CustomerPhone = "8908903246",
					JobId = "jbsdftrr343",
					ServiceType = "Service"
				},
				new JobVM
				{
					CustomerName = "Arjun",
					CustomerPhone = "8908903247",
					JobId = "jb43rtert",
					ServiceType = "Service"
				},
				new JobVM
				{
					CustomerName = "Nakul",
					CustomerPhone = "8908903248",
					JobId = "jbsdfsf2346",
					ServiceType = "New"
				},
				new JobVM
				{
					CustomerName = "Sahdev",
					CustomerPhone = "8908903249",
					JobId = "jb342sefs",
					ServiceType = "New"
				}
			};

			return jobs;
		}
	}
}