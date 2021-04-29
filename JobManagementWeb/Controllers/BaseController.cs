using System;
using System.Collections.Generic;
using System.Diagnostics;
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

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
				},
				new EngineerVM
				{
					EngineerId = "en1006",
					EngineerName = "Nagraj",
					GroupId = "grp001",
					GroupName = "Venom",
					IsSupervisor = true
				},
				new EngineerVM
				{
					EngineerId = "en2001",
					EngineerName = "Peter",
					GroupId = "grp002",
					GroupName = "Commando"
				},
				new EngineerVM
				{
					EngineerId = "en2002",
					EngineerName = "Karim",
					GroupId = "grp002",
					GroupName = "Commando"
				},
				new EngineerVM
				{
					EngineerId = "en2003",
					EngineerName = "Natasha",
					GroupId = "grp002",
					GroupName = "Commando"
				},
				new EngineerVM
				{
					EngineerId = "en2004",
					EngineerName = "Samri",
					GroupId = "grp002",
					GroupName = "Commando"
				},
				new EngineerVM
				{
					EngineerId = "en2005",
					EngineerName = "Kirigi",
					GroupId = "grp002",
					GroupName = "Commando"
				},
				new EngineerVM
				{
					EngineerId = "en2006",
					EngineerName = "Renu",
					GroupId = "grp002",
					GroupName = "Commando"
				},
				new EngineerVM
				{
					EngineerId = "en2007",
					EngineerName = "Dhruv",
					GroupId = "grp002",
					GroupName = "Commando",
					IsSupervisor = true
				},
				new EngineerVM
				{
					EngineerId = "en5001",
					EngineerName = "Parmanu",
					GroupId = "grpFreePool",
					GroupName = "FreePool",
					IsSupervisor = false
				},
				new EngineerVM
				{
					EngineerId = "en5002",
					EngineerName = "Bhokal",
					GroupId = "grpFreePool",
					GroupName = "FreePool",
					IsSupervisor = false
				},
				new EngineerVM
				{
					EngineerId = "en5003",
					EngineerName = "Shakti",
					GroupId = "grpFreePool",
					GroupName = "FreePool",
					IsSupervisor = false
				},
				new EngineerVM
				{
					EngineerId = "en5004",
					EngineerName = "Steel",
					GroupId = "grpFreePool",
					GroupName = "FreePool",
					IsSupervisor = false
				},
				new EngineerVM
				{
					EngineerId = "en5005",
					EngineerName = "Tiranga",
					GroupId = "grpFreePool",
					GroupName = "FreePool",
					IsSupervisor = false
				},
				new EngineerVM
				{
					EngineerId = "en5006",
					EngineerName = "Kobi",
					GroupId = "grpFreePool",
					GroupName = "FreePool",
					IsSupervisor = false
				}
			};

			return engineers;
		}
	
		protected List<GroupVM> GetGroups()
		{
			List<GroupVM> groups = new List<GroupVM>
			{
				new GroupVM
				{
					CreatedOn = "20210421",
					GroupDescription = "The people related to Nagraj",
					GroupId = "grp001",
					GroupName = "Venom",
					Engineers = GetEngineers().Where(e=>e.GroupId == "grp001" && !e.IsSupervisor).ToList(),
					Supervisor = GetEngineers().Where(e=>e.GroupId == "grp001" && e.IsSupervisor).FirstOrDefault(),
				},
				new GroupVM
				{
					CreatedOn = "20210421",
					GroupDescription = "The people related to Dhruv",
					GroupId = "grp002",
					GroupName = "Commando",
					Engineers = GetEngineers().Where(e=>e.GroupId == "grp002" && !e.IsSupervisor).ToList(),
					Supervisor = GetEngineers().Where(e=>e.GroupId == "grp002" && e.IsSupervisor).FirstOrDefault(),
				},
				new GroupVM
				{
					CreatedOn = "20210421",
					GroupDescription = "The people related to Doga",
					GroupId = "grp003",
					GroupName = "Canine"
				},
				new GroupVM
				{
					CreatedOn = "20210421",
					GroupDescription = "FreePool",
					GroupId = "grpFreePool",
					GroupName = "FreePool"
				},
			};

			return groups;
		}

	}
}