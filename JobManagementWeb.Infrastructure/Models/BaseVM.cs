using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public abstract class BaseVM
	{
		public string UserName { get; set; }

		public string CreatedOn { get; set; }
	}
}
