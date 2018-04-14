using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpledotNetCoreAPI.Controllers
{
    [Route("/")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            return "Hello World!";
        }
        [HttpGet("ping")]
        public string Get(int id)
        {
            return "pong";
        }
    }
}
