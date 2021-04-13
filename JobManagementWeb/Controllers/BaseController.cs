using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobManagementWeb.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobManagementWeb.Controllers
{
    public abstract class BaseController : Controller
    {

        [ActionName("SignOut")]
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }


		protected List<JobVM> GetJobs()
		{
			string dateTimeFormat = "yyyy-MM-ddThh:mm:ssZ";
			List<JobVM> jobs = new List<JobVM>
			{
				new JobVM
				{
					CustomerName = "Yudhi",
					CustomerPhone = "8908903245",
					JobId = "jbasd2313",
					ServiceType = "New",
					AssignedOn = DateTime.Now.AddDays(-3),
					AssignedTo = new EngineerVM
						{
							EngineerId = "en1001",
							EngineerName = "Visarpi",
						},
					JobStatuses = new List<StatusVM>
					{
						new StatusVM
						{
							StatusId = "st1001",
							StatusName = "AcceptJob",
							StatusDescription = "Accepted the job",
							CreatedOn = DateTime.Now.AddDays(-3).AddHours(-6).ToString(dateTimeFormat)
						},
						new StatusVM
						{
							StatusId = "st1002",
							StatusName = "Completing Job",
							StatusDescription = "Completing Job",
							CreatedOn = DateTime.Now.AddDays(-3).AddHours(-4).ToString(dateTimeFormat)
						},
						new StatusVM
						{
							StatusId = "st1002",
							StatusName = "Reaching Site",
							StatusDescription = "Reaching Site",
							CreatedOn = DateTime.Now.AddDays(-3).AddHours(-2).ToString(dateTimeFormat)
						}
					}
				},
				new JobVM
				{
					CustomerName = "Bheem",
					CustomerPhone = "8908903246",
					JobId = "jbsdftrr343",
					ServiceType = "Service",
					AssignedTo = new EngineerVM
						{
							EngineerId = "en1002",
							EngineerName = "Ketki",
						},
					JobStatuses = new List<StatusVM>
					{
						new StatusVM
						{
							StatusId = "st1001",
							StatusName = "AcceptJob",
							StatusDescription = "Accepted the job",
							CreatedOn = DateTime.Now.AddDays(-2).AddHours(-9).ToString(dateTimeFormat)
						},
						new StatusVM
						{
							StatusId = "st1002",
							StatusName = "Reaching Site",
							StatusDescription = "Reaching Site",
							CreatedOn = DateTime.Now.AddDays(-2).AddHours(-6).ToString(dateTimeFormat)
						}
					}
				},
				new JobVM
				{
					CustomerName = "Arjun",
					CustomerPhone = "8908903247",
					JobId = "jb43rtert",
					ServiceType = "Service",
					AssignedTo = new EngineerVM
						{
							EngineerId = "en1003",
							EngineerName = "Tuhin",
						},
					JobStatuses = new List<StatusVM>
					{
						new StatusVM
						{
							StatusId = "st1001",
							StatusName = "AcceptJob",
							StatusDescription = "Accepted the job",
							CreatedOn = DateTime.Now.AddDays(-2).AddHours(-9).ToString(dateTimeFormat)
						}
					}
				},
				new JobVM
				{
					CustomerName = "Nakul",
					CustomerPhone = "8908903248",
					JobId = "jbsdfsf2346",
					ServiceType = "New",
					AssignedTo = new EngineerVM
						{
							EngineerId = "en1004",
							EngineerName = "Nisha",
						},
					JobStatuses = new List<StatusVM>
					{
						new StatusVM
						{
							StatusId = "st1001",
							StatusName = "AcceptJob",
							StatusDescription = "Accepted the job",
							CreatedOn = DateTime.Now.AddDays(-2).AddHours(-9).ToString(dateTimeFormat)
						},
						new StatusVM
						{
							StatusId = "st1002",
							StatusName = "Reaching Site",
							StatusDescription = "Reaching Site",
							CreatedOn = DateTime.Now.AddDays(-2).AddHours(-6).ToString(dateTimeFormat)
						}
					}
				},
				new JobVM
				{
					CustomerName = "Sahdev",
					CustomerPhone = "8908903249",
					JobId = "jb342sefs",
					ServiceType = "New",
					AssignedTo = new EngineerVM
						{
							EngineerId = "en1005",
							EngineerName = "Kasi",
						},
					JobStatuses = new List<StatusVM>
					{
						new StatusVM
						{
							StatusId = "st1002",
							StatusName = "Reaching Site",
							StatusDescription = "Reaching Site",
							CreatedOn = DateTime.Now.AddDays(-2).AddHours(-6).ToString(dateTimeFormat)
						},
						new StatusVM
						{
							StatusId = "st1003",
							StatusName = "Completing Job",
							StatusDescription = "Completing Job",
							CreatedOn = DateTime.Now.AddDays(-2).AddHours(-1).ToString(dateTimeFormat)
						},
						new StatusVM
						{
							StatusId = "st1001",
							StatusName = "AcceptJob",
							StatusDescription = "Accepted the job",
							CreatedOn = DateTime.Now.AddDays(-2).AddHours(-9).ToString(dateTimeFormat)
						}
					}
				}
			};

			return jobs;
		}

		protected List<EngineerVM> GetEngineers()
		{
			List<EngineerVM> engineers = new List<EngineerVM>
			{
				new EngineerVM
				{
					EngineerId = "en1001",
					EngineerName = "Visarpi",
					GroupId = "grp001",
					GroupName = "Venom"
				},
				new EngineerVM
				{
					EngineerId = "en1002",
					EngineerName = "Ketki",
					GroupId = "grp001",
					GroupName = "Venom"
				},
				new EngineerVM
				{
					EngineerId = "en1003",
					EngineerName = "Tuhin",
					GroupId = "grp001",
					GroupName = "Venom"
				},
				new EngineerVM
				{
					EngineerId = "en1004",
					EngineerName = "Nisha",
					GroupId = "grp001",
					GroupName = "Venom"
				},
				new EngineerVM
				{
					EngineerId = "en1005",
					EngineerName = "Kasi",
					GroupId = "grp001",
					GroupName = "Venom"
				}
			};

			return engineers;
		}
	
	}
}