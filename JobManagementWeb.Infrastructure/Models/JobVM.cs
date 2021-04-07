using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public class JobVM
	{
		public string JobId { get; set; }

		public string CustomerName { get; set; }

		public string CustomerPhone { get; set; }

		public string ServiceType { get; set; }

		public string Message { get; set; }
	}
}
