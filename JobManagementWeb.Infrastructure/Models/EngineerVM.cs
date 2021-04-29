using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public class EngineerVM
	{
		public EngineerVM()
		{
			IsSupervisor = false;
		}

		public string EngineerId { get; set; }

		public string EngineerName { get; set; }

		public string GroupId { get; set; }

		public string GroupName { get; set; }

		public bool IsSupervisor { get; set; }

	}
}
