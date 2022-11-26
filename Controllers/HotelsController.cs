﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HotelBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        // GET
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET 
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST 
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT 
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE 
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}