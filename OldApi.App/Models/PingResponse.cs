using System;

namespace OldApi.App.Models
{
	public class PingResponse 
	{
		public int Id { get; set; }
		public string Message { get; set; }
		public string Status { get; set; }
		public DateTime Timestamp { get; set; }
	}
}
