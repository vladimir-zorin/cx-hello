using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CxApi.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        // GET api/hello
        [HttpGet]
        public string Get()
        {
            return "Hello Who?";
        }

        // GET api/hello/name
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return "Hello " + name;
        }
    }
}
