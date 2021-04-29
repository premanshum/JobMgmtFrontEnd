using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public class GroupVM : BaseVM
	{
		public GroupVM()
		{
			Supervisor = new EngineerVM();
			Engineers = new List<EngineerVM>();
		}

		public string GroupId { get; set; }

		public string GroupName { get; set; }

		public string GroupDescription { get; set; }

		public List<EngineerVM> Engineers { get; set; }

		public EngineerVM Supervisor { get; set; }

	}
}
