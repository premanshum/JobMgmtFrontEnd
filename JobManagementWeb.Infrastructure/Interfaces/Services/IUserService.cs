using JobManagementWeb.Infrastructure.Entities;
using JobManagementWeb.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Interfaces.Services
{
	public interface IUserService
	{
		LoginResponse Login(Request<UserProfile> loginRequest);
	}
}
