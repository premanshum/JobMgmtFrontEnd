using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public class HomePageVM
	{
		public List<JobVM> Jobs { get; set; }

		public JobVM Job { get; set; }

		public SearchJobVM Search { get; set; }
	}
}
