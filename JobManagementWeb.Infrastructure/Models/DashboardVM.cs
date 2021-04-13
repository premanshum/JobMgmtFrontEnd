using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public class DashboardVM
	{
		public DashboardVM()
		{
			Jobs = new List<JobVM>();
			Engineers = new List<EngineerVM>();
		}

		public List<JobVM> Jobs { get; set; }

		public IEnumerable<EngineerVM> Engineers { get; set; }

		public JobVM Job { get; set; }

		public EngineerVM Engineer { get; set; }

		public string EngineerId { get; set; }
	}
}
