using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace GettingStartedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            List<string> output = new();

            for (int i = 0; i < Random.Shared.Next(2,10); i++) 
            {
                output.Add($"Value #{i+1}");
            }

            return output;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Value #{id+1}";
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // PATCH api/<UsersController>/5
        [HttpPatch("{id}")]
        public void Patch(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
