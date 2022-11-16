﻿using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _9_het.Controllers
{
    [Route("api/joke")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        // GET: api/joke
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<JokesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JokesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JokesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JokesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
