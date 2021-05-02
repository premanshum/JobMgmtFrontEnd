using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Utility;

namespace JobManagementWeb.Repository
{
	public class ServiceHttpClient : HttpClient
	{
		public ServiceHttpClient(string url, string token)
		{
			BaseAddress = new Uri(url);
			DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.APPLICATION_JSON));
			if (!string.IsNullOrEmpty(token))
			{
				DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.BEARER, token);
			}
		}
	}
}
