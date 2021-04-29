using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Utility;

namespace JobManagementWeb.Infrastructure.Models
{
	public class JobVM
	{
		List<StatusVM> _JobStatuses;

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

		public List<StatusVM> JobStatuses {
			get
			{
				return _JobStatuses;
			}
			set
			{
				_JobStatuses = value;
				_JobStatuses.Sort((x, y) => {
					return SortUtility.CompareByCreatedOn(x.CreatedOn, y.CreatedOn);
				});
			} 
		}

		public StatusVM CurrentStatus
		{
			get
			{
				if (JobStatuses == null || !JobStatuses.Any())
				{
					return null;
				}
				return JobStatuses.First();
			}
		}
	}
}
