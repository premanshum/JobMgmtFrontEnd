using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Entities
{
	public class LoginResponse : Response<string>
	{
		public string Token { get; set; }

		public string Expiration { get; set; }

		public string UserName { get; set; }
	}
}
