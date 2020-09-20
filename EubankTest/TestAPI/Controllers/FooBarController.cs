using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooBarController : ControllerBase
    {
        // GET api/foobar/<number>
        [HttpGet("{number}")]
        public IActionResult Get(int number)
        {
            string result;
            if (number % 3 == 0 && number % 5 == 0)
                result = "foobar";
            else if (number % 3 == 0)
                result = "foo";
            else if (number % 5 == 0)
                result = "bar";
            else
                return NotFound();

            return new ObjectResult(result);
        }
    }
}
