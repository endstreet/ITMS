using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ITMS.Integration.ESB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatreController : ControllerBase
    {

        private readonly ILogger<TheatreController> _logger;
        public TheatreController(ILogger<TheatreController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{hospitalcode}")]
        public IEnumerable<Theatre> GetComplexTheatres(string HospitalCode)
        {
            //todo: get the data from ESB and replace TestData.registers
            return JsonConvert.DeserializeObject<List<Theatre>>(JsonConvert.DeserializeObject<JObject>(TestData.theatres).First.First.ToString());
        }
    }
}