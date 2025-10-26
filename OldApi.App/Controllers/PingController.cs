using OldApi.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OldApi.App.Controllers
{
	[RoutePrefix("api/ping")]
	public class PingController : ApiController
    {
		// GET: api/Ping
		[HttpGet]
		[Route("")]
		public IHttpActionResult Get()
        {
			var response = new PingResponse
			{
				Id = 0,
				Message = "Pong",
				Status = "OK",
				Timestamp = DateTime.UtcNow
			};
			return Ok(response);
		}

        // GET: api/Ping/5
        [HttpGet]
		[Route("{id:int}")]
		public IHttpActionResult Get(int id)
        {
			var response = new PingResponse
			{
				Id = id,
				Message = "Pong",
				Status = "OK",
				Timestamp = DateTime.UtcNow
			};

			return Ok(response);
		}

		// POST: api/ping
		[HttpPost]
		[Route("")]
		public IHttpActionResult Post([FromBody] PingRequest request) 
		{
			if(request is null) 
				return BadRequest("Invalid request, cannot be null.");
			var response = CreatePingResponse(request, "Received");
			return Ok(response);
		}

		// PUT: api/Ping/5
		[HttpPut]
		[Route("{id:int}")]
		public IHttpActionResult Put(int id, [FromBody] PingRequest request)
		{
			if (request is null)
				return BadRequest("Invalid request, cannot be null.");

			var response = CreatePingResponse(request, "Updated");
			return Ok(response);
        }

		// DELETE: api/Ping/5
		[HttpDelete]
		[Route("{id:int}")]
		public IHttpActionResult Delete(int id)
        {
			var response = new PingResponse
			{
				Id = id,
				Message = "Deleted",
				Status = "OK",
				Timestamp = DateTime.UtcNow
			};
			return Ok(response);
		}

		private PingResponse CreatePingResponse(PingRequest request, string status) 
		{
			return new PingResponse
			{
				Id = request.Id,
				Message = request.Message,
				Status = "Received", //status
				Timestamp = DateTime.UtcNow
			};
		}
    }
}
