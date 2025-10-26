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

        // POST: api/Ping
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Ping/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Ping/5
        public void Delete(int id)
        {
        }
    }
}
