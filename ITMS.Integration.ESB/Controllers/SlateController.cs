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
    public class SlateController : ControllerBase
    {

        private readonly ILogger<SlateController> _logger;
        public SlateController(ILogger<SlateController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{hospitalcode}")]
        public IEnumerable<Slate> GetRegisters(string HospitalCode)
        {
            //todo: get the data from ESB and replace TestData.registers
            return JsonConvert.DeserializeObject<List<Slate>>(JsonConvert.DeserializeObject<JObject>(TestData.slates).First.First.ToString());
        }
    }
}