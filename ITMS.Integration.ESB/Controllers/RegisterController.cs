using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ITMS.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ITMS.Integration.ESB.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ILogger<RegisterController> _logger;
        public RegisterController(ILogger<RegisterController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{hospitalcode}")]
        public IEnumerable<Register> GetRegisters(string HospitalCode)
        {
            //todo: get the data from ESB and replace TestData.registers
            return JsonConvert.DeserializeObject<List<Register>>(JsonConvert.DeserializeObject<JObject>(TestData.registers).First.First.ToString());
        }
    }
}