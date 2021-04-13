using JobManagementWeb.Utility.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
	public static class SortUtility
	{
		public static int CompareByCreatedOn(string x, string y) 
		{
			var xDate = DateTime.Parse(x.TryParseDate());
			var yDate = DateTime.Parse(y.TryParseDate());
			int comp = DateTime.Compare(yDate, xDate);
			return comp;
		}
	}
}
