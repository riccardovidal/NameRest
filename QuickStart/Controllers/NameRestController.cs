using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace QuickStart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameRestController : ControllerBase
    {
        [HttpGet("{name}")]
        public IEnumerable<NameRest> Get(string name)
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new NameRest
            {
                Name = "Your name is " + name
            })
            .ToArray();
        }
    }
}