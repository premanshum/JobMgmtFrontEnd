using JobManagementWeb.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public class StatusVM : BaseVM
	{
		public string StatusId { get; set; }

		public string StatusName { get; set; }

		public string StatusDescription { get; set; }

		public string TimeStamp 
		{
			get
			{
				return CreatedOn.TryParseDate("dd MMM \\`yy \"at\" hh:mm tt");
			}
		}
	}
}
