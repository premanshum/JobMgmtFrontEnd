using System.Collections.Generic;

namespace JobManagementWeb.Infrastructure.Models
{
	public class JobAssignmentVM
	{
		public JobAssignmentVM()
		{
			Jobs = new List<JobVM>();
			Engineers = new List<EngineerVM>();
		}

		public List<JobVM> Jobs { get; set; }

		public List<EngineerVM> Engineers { get; set; }
	}
}
