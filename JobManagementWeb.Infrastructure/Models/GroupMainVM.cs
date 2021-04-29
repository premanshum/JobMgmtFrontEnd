using System.Collections.Generic;

namespace JobManagementWeb.Infrastructure.Models
{
	public class GroupMainVM
	{
		public GroupMainVM()
		{
			Groups = new List<GroupVM>();
		}

		public List<GroupVM> Groups { get; set; }
	}
}
