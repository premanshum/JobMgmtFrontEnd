namespace JobManagementWeb.Infrastructure.Models
{
	public class ServiceCenterVM
	{
		public ServiceCenterVM()
		{
			Job = new JobVM();
			Search = new SearchJobVM();
		}

		public JobVM Job { get; set; }

		public SearchJobVM Search { get; set; }
	}
}
