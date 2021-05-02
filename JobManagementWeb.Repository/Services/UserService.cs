using JobManagementWeb.Infrastructure.Entities;
using JobManagementWeb.Infrastructure.Interfaces.Services;
using JobManagementWeb.Infrastructure.Models;
using System;

namespace JobManagementWeb.Repository.Services
{
	public class UserService : IUserService
	{
		public LoginResponse Login(Request<UserProfile> loginRequest)
		{
			var serviceCaller = new ServiceCaller();
			try
			{
				var response = serviceCaller.MakeLoginRequestPost<UserProfile, LoginResponse>(loginRequest);

				return response;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
	}
}
