using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementWeb.Infrastructure.Entities
{
	public class Response<T>
	{
		public Response()
		{
			Data = new List<T>();
			Errors = new List<string>();
		}

		public List<T> Data { get; set; }

		public List<string> Errors { get; set; }

		public string ErrorCode { get; set; }

		public double TimeTakenInMS { get; set; }

		public string CorelationId { get; set; }
	}
}
