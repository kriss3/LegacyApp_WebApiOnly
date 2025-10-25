using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OldApi.App.Models
{
	public class PingRequest
	{
		public int Id { get; set; }
		public string Message { get; set; }
	}

	public class PingResponse 
	{
		public int Id { get; set; }
		public string Message { get; set; }
		public string Status { get; set; }
		public System.DateTime Timestamp { get; set; }
	}
}