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
    public class ComplexController : ControllerBase
    {

        private readonly ILogger<ComplexController> _logger;
        public ComplexController(ILogger<ComplexController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{hospitalcode}")]
        public IEnumerable<Complex> GetComplexes(string HospitalCode)
        {
            //todo: get the data from ESB and replace TestData.registers
            return JsonConvert.DeserializeObject<List<Complex>>(JsonConvert.DeserializeObject<JObject>(TestData.complexes).First.First.ToString());
        }
    }
}