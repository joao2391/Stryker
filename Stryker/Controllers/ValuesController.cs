using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Stryker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var toTest = id;

            if (string.IsNullOrEmpty(toTest))
            {
                return BadRequest();
            }

            return Ok();
        }

        // GET api/values/another
        [HttpGet("another")]
        public async Task<IActionResult> GetAnother(string id)
        {

            var toTest = id;

            if (string.IsNullOrEmpty(toTest))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet("user")]
        public async Task<IActionResult> GetUser(User user)
        {
            var toTest = user.Name;

            if (string.IsNullOrEmpty(user.Name))
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet("user2")]
        public async Task<IActionResult> GetAnotherUser(User user)
        {
            var toTest = user.Name;

            if (string.IsNullOrEmpty(user.Name))
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
