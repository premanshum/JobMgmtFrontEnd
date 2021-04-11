using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobManagementWeb.Infrastructure.Models
{
	public class JobVM
	{
		public string JobId { get; set; }

		[Display(Name = "Customer Name")]
		public string CustomerName { get; set; }

		[Display(Name = "Customer Phone")]
		public string CustomerPhone { get; set; }

		[Display(Name = "Service Type")]
		public string ServiceType { get; set; }

		public string Message { get; set; }

		[Display(Name = "Assigned To")]
		public EngineerVM AssignedTo { get; set; }

		public DateTime AssignedOn { get; set; }

		public List<StatusVM> JobStatuses { get; set; }

	}
}
