using JobManagementWeb.Infrastructure.Interfaces.Services;
using System.Collections.Generic;

namespace JobManagementWeb.Infrastructure.Models
{
	public class GroupMainVM : BaseVM
	{
		public GroupMainVM()
		{
			Groups = new List<GroupVM>();
		}

		public GroupMainVM(ISessionValues sessionValues)
		{

		}

		public List<GroupVM> Groups { get; set; }
	}
}
