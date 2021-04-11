using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public class StatusVM
	{
		public string StatusId { get; set; }

		public string StatusName { get; set; }

		public string StatusDescription { get; set; }

		public string CreatedOn { get; set; }

		public string TimeStamp { get; set; }
	}
}
